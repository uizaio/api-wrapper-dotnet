using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Uiza.Net.Response
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateUserResponse : UizaResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
