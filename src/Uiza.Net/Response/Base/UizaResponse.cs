using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Uiza.Net.Response
{
    /// <summary>
    /// 
    /// </summary>
    public class UizaResponse : IUizaResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("version")]
        public int Version { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("datetime")]
        public string DateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("policy")]
        public string policy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("requestId")]
        public string RequestId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("serviceName")]
        public string ServiceName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("code")]
        public int Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metadata")]
        public dynamic MetaData { get; set; }
    }
}
