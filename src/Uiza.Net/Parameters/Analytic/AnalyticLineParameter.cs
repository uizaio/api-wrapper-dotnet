using Newtonsoft.Json;

namespace Uiza.Net.Parameters
{
    /// <summary>
    ///
    /// </summary>
    public class AnalyticLineParameter : BaseParameter
    {
        /// <summary>
        ///
        /// </summary>
        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("end_date")]
        public string EndDate { get; set; }
    }
}