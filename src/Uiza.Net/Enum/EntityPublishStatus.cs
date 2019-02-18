using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Uiza.Net.Enums
{
    /// <summary>
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EntityPublishStatus
    {
        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "queue")]
        Queue,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "not-ready")]
        NotReady,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "success")]
        Success,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "failed")]
        Failed
    }
}