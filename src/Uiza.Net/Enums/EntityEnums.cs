using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Uiza.Net.Enums
{
    /// <summary>
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EntityInputTypes
    {
        /// <summary>
        /// Type of URL : s3-uiza
        /// </summary>
        [EnumMember(Value = "s3-uiza")]
        S3Uiza,

        /// <summary>
        /// Type of URL : http
        /// </summary>
        [EnumMember(Value = "http")]
        Http,

        /// <summary>
        /// Type of URL : s3
        /// </summary>
        [EnumMember(Value = "s3")]
        S3,

        /// <summary>
        /// Type of URL : ftp
        /// </summary>
        [EnumMember(Value = "ftp")]
        Ftp
    }

    /// <summary>
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EntityTypes
    {
        /// <summary>
        /// Type of Entity : vod
        /// </summary>
        [EnumMember(Value = "vod")]
        VOD,

        /// <summary>
        /// Type of Entity : aod
        /// </summary>
        [EnumMember(Value = "aod")]
        AOD
    }

    /// <summary>
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EntityPublishStatus
    {
        /// <summary>
        /// Status of publish task : queue
        /// </summary>
        [EnumMember(Value = "queue")]
        Queue,

        /// <summary>
        /// Status of publish task : not-ready
        /// </summary>
        [EnumMember(Value = "not-ready")]
        NotReady,

        /// <summary>
        /// Status of publish task : success
        /// </summary>
        [EnumMember(Value = "success")]
        Success,

        /// <summary>
        /// Status of publish task : failed
        /// </summary>
        [EnumMember(Value = "failed")]
        Failed
    }
}