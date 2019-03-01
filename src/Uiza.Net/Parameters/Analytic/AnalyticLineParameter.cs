using Newtonsoft.Json;

namespace Uiza.Net.Parameters
{
    /// <summary>
    ///
    /// </summary>
    public class AnalyticLineParameter : BaseParameter
    {
        /// <summary>
        /// Start date (UTC+0) with format: YYYY-MM-DD
        /// </summary>
        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// End date (UTC+0) with format: YYYY-MM-DD
        /// </summary>
        [JsonProperty("end_date")]
        public string EndDate { get; set; }
    }
}