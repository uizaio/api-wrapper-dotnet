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
        ///
        /// </summary>
        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("type_filter")]
        public MetricTypeFilter TypeFilter { get; set; }
    }
}