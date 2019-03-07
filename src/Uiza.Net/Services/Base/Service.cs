using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading;
using System.Threading.Tasks;
using Uiza.Net.Parameters;
using Uiza.Net.Utility;

namespace Uiza.Net.Services
{
    /// <summary>
    ///
    /// </summary>
    public abstract class Service
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="url"></param>
        /// <param name="options"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        protected async Task<T> PostRequestAsync<T>(string url, BaseParameter options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return MapFromJson<T>(await Request.PostStringAsync(url, options, cancellationToken).ConfigureAwait(false));
        }

        /// <summary>
        ///
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        protected T PostRequest<T>(string url, BaseParameter options = null)
        {
            return MapFromJson<T>(Request.PostString(url, options));
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="url"></param>
        /// <param name="options"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        protected async Task<T> GetRequestAsync<T>(string url, BaseParameter options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return MapFromJson<T>(await Request.GetStringAsync(url, options, cancellationToken).ConfigureAwait(false));
        }

        /// <summary>
        ///
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        protected T GetRequest<T>(string url, BaseParameter options = null)
        {
            return MapFromJson<T>(Request.GetString(url, options));
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="url"></param>
        /// <param name="options"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        protected async Task<T> PutRequestAsync<T>(string url, BaseParameter options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return MapFromJson<T>(await Request.PutStringAsync(url, options, cancellationToken).ConfigureAwait(false));
        }

        /// <summary>
        ///
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        protected T PutRequest<T>(string url, BaseParameter options = null)
        {
            return MapFromJson<T>(Request.PutString(url, options));
        }

        /// <summary>
        ///
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        protected T DeleteRequest<T>(string url, BaseParameter options = null)
        {
            return MapFromJson<T>(Request.DeleteString(url, options));
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="url"></param>
        /// <param name="options"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        protected async Task<T> DeleteRequestAsync<T>(string url, BaseParameter options = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            return MapFromJson<T>(await Request.DeleteStringAsync(url, options, cancellationToken).ConfigureAwait(false));
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="json"></param>
        /// <param name="parentToken"></param>
        /// <returns></returns>
        public static T MapFromJson<T>(string json, string parentToken = null)
        {
            var jsonToParse = string.IsNullOrEmpty(parentToken) ? json : JObject.Parse(json).SelectToken(parentToken).ToString();

            var result = JsonConvert.DeserializeObject<T>(json);

            return result;
        }
    }
}