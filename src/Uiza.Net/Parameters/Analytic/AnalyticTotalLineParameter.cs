using Newtonsoft.Json;
using Uiza.Net.Enums;

namespace Uiza.Net.Parameters
{
    /// <summary>
    ///
    /// </summary>
    public class AnalyticTotalLineParameter : BaseParameter
    {
        /// <summary>
        /// Start date (UTC+0) with format: YYYY-MM-DD hh:mm (24-hour clock)
        /// </summary>
        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// End date (UTC+0) with format: YYYY-MM-DD hh:mm (24-hour clock)
        /// </summary>
        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// You can get data of any metric from list (use Slug)
        /// </summary>
        [JsonProperty("metric")]
        public MetricType Metric { get; set; }
    }
}