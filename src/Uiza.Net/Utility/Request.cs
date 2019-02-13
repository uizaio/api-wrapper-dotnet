using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Uiza.Net.Configuration;
using Uiza.Net.Parameters;
using Uiza.Net.Response;
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

            return ExecuteRequest(wr);
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

            return ExecuteRequestAsync(wr, cancellationToken);
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
            var apiUrl = $"{UizaConfiguration.ApiBase}/{Constants.DefaultApiRoute}/{url}";
            var request = RenderRequest(method, apiUrl, param);
            var apiKey = UizaConfiguration.GetApiKey();
            if (!string.IsNullOrWhiteSpace(apiKey))
                request.Headers.Add("Authorization", UizaConfiguration.GetApiKey());

            return request;
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
            var serialzeObject = JsonConvert.SerializeObject(param);

            if (method != HttpMethod.Post && method != HttpMethod.Put)
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
                Content = new StringContent(JsonConvert.SerializeObject(param), Encoding.UTF8, "application/json")
            };

            return request;
        }
        /// <summary>
        /// Excute Request With Async
        /// </summary>
        /// <param name="requestMessage"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        private static async Task<string> ExecuteRequestAsync(HttpRequestMessage requestMessage, CancellationToken cancellationToken = default(CancellationToken))
        {
            var response = await HttpClient.SendAsync(requestMessage, cancellationToken).ConfigureAwait(false);
            var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                return responseText;
            }

            throw HandleUizaException(responseText);
        }

        /// <summary>
        /// Excute Request
        /// </summary>
        /// <param name="requestMessage"></param>
        /// <returns></returns>
        private static string ExecuteRequest(HttpRequestMessage requestMessage)
        {
            var response = HttpClient.SendAsync(requestMessage).ConfigureAwait(false).GetAwaiter().GetResult();
            var responseText = response.Content.ReadAsStringAsync().ConfigureAwait(false).GetAwaiter().GetResult();

            if (response.IsSuccessStatusCode)
            {
                return responseText;
            }

            throw HandleUizaException(responseText);
        }

        /// <summary>
        /// Handle Uiza Exception
        /// </summary>
        /// <param name="errorsResponse"></param>
        /// <returns></returns>
        private static UizaException HandleUizaException(string errorsResponse)
        {
            return new UizaException(JsonConvert.DeserializeObject<UizaExceptionResponse>(errorsResponse));
        }
        #endregion
    }
}
