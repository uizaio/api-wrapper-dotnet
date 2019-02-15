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
        [JsonProperty("metadata")]
        public dynamic MetaData { get; set; }
    }
}
