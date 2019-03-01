using Newtonsoft.Json;
using Uiza.Net.Enum;

namespace Uiza.Net.Parameters
{
    /// <summary>
    ///
    /// </summary>
    public class AnalyticTypeParameter : BaseParameter
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

        /// <summary>
        /// Value accept: [ country, device, title, player ]
        /// </summary>
        [JsonProperty("type_filter")]
        public MetricTypeFilter TypeFilter { get; set; }
    }
}