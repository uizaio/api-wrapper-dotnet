using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Uiza.Net.Response
{
    /// <summary>
    /// 
    /// </summary>
    public class MetaDataResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("result")]
        public int Result { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }
    }
}
