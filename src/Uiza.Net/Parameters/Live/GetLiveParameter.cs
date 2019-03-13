using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Uiza.Net.Enums;

namespace Uiza.Net.Parameters
{
    /// <summary>
    /// 
    /// </summary>
    public class GetLiveParameter : RetrieveItemParameter
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status")]
        public LiveStatus? LiveStatus { get; set; }
    }
}
