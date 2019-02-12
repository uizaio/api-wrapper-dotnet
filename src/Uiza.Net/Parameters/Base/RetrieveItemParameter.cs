using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Uiza.Net.Parameters
{
    /// <summary>
    /// 
    /// </summary>
    public class RetrieveItemParameter : BaseParameter
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
