using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Uiza.Net.Configuration;
using Uiza.Net.Enums;
using Uiza.Net.Extension;
using Uiza.Net.Parameters;
using Uiza.Net.UizaHandleException;

namespace Uiza.Net.Utility
{
    /// <summary>
    ///
    /// </summary>
    internal static class Request
    {
        /// <summary>
        ///
        /// </summary>
        internal static HttpClient HttpClient { get; private set; }

        /// <summary>
        /// Request Constructor
        /// </summary>
        static Request()
        {
            HttpClient = new HttpClient();
        }

        /// <summary>
        /// Excute POST API with Async
        /// </summary>
        /// <param name="url"></param>
        /// <param name="param"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static Task<string> PostStringAsync(string url, BaseParameter param, CancellationToken cancellationToken = default(CancellationToken))
        {
            var wr = CreateRequestConfig(url, param, HttpMethod.Post);

            return ExecuteRequestAsync(wr, cancellationToken);
        }

        /// <summary>
        /// Excute POST API
        /// </summary>
        /// <param name="url"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static string PostString(string url, BaseParameter param)
        {
            var wr = CreateRequestConfig(url, param, HttpMethod.Post);

            return ExecuteRequest(wr, param.DescriptionLink);
        }

        /// <summary>
        /// Excute GET API with Async
        /// </summary>
        /// <param name="url"></param>
        /// <param name="param"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static Task<string> GetStringAsync(string url, BaseParameter param, CancellationToken cancellationToken = default(CancellationToken))
        {
            var wr = CreateRequestConfig(url, param, HttpMethod.Get);

            return ExecuteRequestAsync(wr, cancellationToken, param.DescriptionLink);
        }

        /// <summary>
        ///  Excute GET API
        /// </summary>
        /// <param name="url"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static string GetString(string url, BaseParameter param)
        {
            var wr = CreateRequestConfig(url, param, HttpMethod.Get);

            return ExecuteRequest(wr);
        }

        /// <summary>
        ///  Excute PUT API with Async
        /// </summary>
        /// <param name="url"></param>
        /// <param name="param"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static Task<string> PutStringAsync(string url, BaseParameter param, CancellationToken cancellationToken = default(CancellationToken))
        {
            var wr = CreateRequestConfig(url, param, HttpMethod.Put);

            return ExecuteRequestAsync(wr, cancellationToken);
        }

        /// <summary>
        ///  Excute PUT API
        /// </summary>
        /// <param name="url"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static string PutString(string url, BaseParameter param)
        {
            var wr = CreateRequestConfig(url, param, HttpMethod.Put);

            return ExecuteRequest(wr);
        }

        /// <summary>
        ///  Excute DELTE API with Async
        /// </summary>
        /// <param name="url"></param>
        /// <param name="param"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static Task<string> DeleteStringAsync(string url, BaseParameter param, CancellationToken cancellationToken = default(CancellationToken))
        {
            var wr = CreateRequestConfig(url, param, HttpMethod.Delete);

            return ExecuteRequestAsync(wr, cancellationToken);
        }

        /// <summary>
        /// Excute DELTE API
        /// </summary>
        /// <param name="url"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static string DeleteString(string url, BaseParameter param)
        {
            var wr = CreateRequestConfig(url, param, HttpMethod.Delete);

            return ExecuteRequest(wr);
        }

        #region Private Method

        /// <summary>
        /// Append Parameter To URL
        /// </summary>
        /// <param name="requestString"></param>
        /// <param name="argument"></param>
        /// <param name="value"></param>
        private static void ApplyParameterToRequestString(ref string requestString, string argument, string value)
        {
            var token = requestString.Contains("?") ? "&" : "?";
            requestString = $"{requestString}{token}{argument}={WebUtility.UrlEncode(value)}";
        }

        /// <summary>
        /// Create Request Configuration
        /// </summary>
        /// <param name="url"></param>
        /// <param name="param"></param>
        /// <param name="method"></param>
        /// <returns></returns>
        private static HttpRequestMessage CreateRequestConfig(string url, BaseParameter param, HttpMethod method)
        {
#if NET45
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
#endif
            var apiKey = UizaConfiguration.GetApiKey();
            if (string.IsNullOrWhiteSpace(apiKey) || string.IsNullOrWhiteSpace(UizaConfiguration.ApiBase))
                ThrowConfigurationError();

            var apiUrl = $"{UizaConfiguration.ApiBase}/{Constants.DEFAULT_API_ROUTE}/{url}".FormatUrl();
            var request = RenderRequest(method, apiUrl, param);
            request.Headers.Add("Authorization", UizaConfiguration.GetApiKey());

            return request;
        }

        private static void ThrowConfigurationError()
        {
            throw new UizaException("Validation Errors", new UizaExceptionResponse()
            {
                Code = (int)ResponseStatusCode.Unauthorized,
                Data = new ErrorData()
                {
                    Field = "Configuration",
                    Message = "Please Setup Uiza Configuration",
                    Type = "Configuration"
                },
                DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.AUTHENTICATION)
            });
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="method"></param>
        /// <param name="url"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        private static HttpRequestMessage RenderRequest(HttpMethod method, string url, BaseParameter param)
        {
            param = param ?? new BaseParameter();
            //var errors = param.GetValidationErrors();
            //if (errors.Any())
            //    throw HandleUizaValidationException(errors);

            var serialzeObject = JsonConvert.SerializeObject(param);

            if (method != HttpMethod.Post && method != HttpMethod.Put && method != HttpMethod.Delete)
            {
                var listParam = JsonConvert.DeserializeObject<Dictionary<string, string>>(serialzeObject);
                foreach (var item in listParam)
                {
                    if (!string.IsNullOrWhiteSpace(item.Value))
                        ApplyParameterToRequestString(ref url, item.Key, item.Value);
                }

                foreach (var item in param.ExtraParams)
                {
                    ApplyParameterToRequestString(ref url, item.Key.ToString(), item.Value.ToString());
                }

                return new HttpRequestMessage(method, new Uri(url));
            }

            var request = new HttpRequestMessage(method, new Uri(url))
            {
                Content = new StringContent(serialzeObject, Encoding.UTF8, "application/json")
            };

            return request;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="requestMessage"></param>
        /// <param name="cancellationToken"></param>
        /// <param name="descriptionLink"></param>
        /// <returns></returns>
        private static async Task<string> ExecuteRequestAsync(HttpRequestMessage requestMessage, CancellationToken cancellationToken = default(CancellationToken), string descriptionLink = null)
        {
            var response = await HttpClient.SendAsync(requestMessage, cancellationToken).ConfigureAwait(false);
            var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                return responseText;
            }

            throw HandleUizaException(responseText, descriptionLink);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="requestMessage"></param>
        /// <param name="descriptionLink"></param>
        /// <returns></returns>
        private static string ExecuteRequest(HttpRequestMessage requestMessage, string descriptionLink = null)
        {
            var response = HttpClient.SendAsync(requestMessage).ConfigureAwait(false).GetAwaiter().GetResult();
            var responseText = response.Content.ReadAsStringAsync().ConfigureAwait(false).GetAwaiter().GetResult();

            if (response.IsSuccessStatusCode)
            {
                return responseText;
            }

            throw HandleUizaException(responseText, descriptionLink);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="errorsResponse"></param>
        /// <param name="descriptionLink"></param>
        /// <returns></returns>
        private static UizaException HandleUizaException(string errorsResponse, string descriptionLink = null)
        {
            var uizaExceptionResponse = JsonConvert.DeserializeObject<UizaExceptionResponse>(errorsResponse);
            uizaExceptionResponse.DescriptionLink = descriptionLink;

            return new UizaException(uizaExceptionResponse);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="errors"></param>
        /// <param name="descriptionLink"></param>
        /// <returns></returns>
        private static UizaException HandleUizaValidationException(IList<ValidationResult> errors, string descriptionLink = null)
        {
            return new UizaException("Validation Errors", new UizaExceptionResponse()
            {
                Data = errors.Select(x => new ErrorData()
                {
                    Field = x.MemberNames.FirstOrDefault(),
                    Message = x.ErrorMessage,
                    Type = "Validate"
                }).ToList(),
                DescriptionLink = descriptionLink
            });
        }

        #endregion Private Method
    }
}