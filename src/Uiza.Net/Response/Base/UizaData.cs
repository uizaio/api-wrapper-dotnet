using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Uiza.Net.Response
{
    /// <summary>
    /// 
    /// </summary>
    public class UizaData : UizaResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data")]
        public dynamic Data { get; set; }
    }
}
