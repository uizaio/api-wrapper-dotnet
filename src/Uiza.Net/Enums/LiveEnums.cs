using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Uiza.Net.Enums
{
    /// <summary>
    ///
    /// </summary>
    public enum DvrTypes
    {
        /// <summary>
        /// No record
        /// </summary>
        NoRecord = 0,

        /// <summary>
        /// Active Feature record
        /// </summary>
        ActiveFeatureRecord,
    }

    /// <summary>
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ResourceModes
    {
        /// <summary>
        /// single = only 1 feed and output
        /// </summary>
        [EnumMember(Value = "single")]
        Single,

        /// <summary>
        /// redundant = more than 1 feed and output to backup
        /// </summary>
        [EnumMember(Value = "redundant")]
        Redundant,
    }

    /// <summary>
    ///
    /// </summary>
    public enum EncodeTypes
    {
        /// <summary>
        /// No record
        /// </summary>
        NoEncode = 0,

        /// <summary>
        /// Active Feature record
        /// </summary>
        Encode,
    }

    /// <summary>
    /// type of social (youtube/facebook).
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TypeOfSocials
    {
        /// <summary>
        ///  type of social youtube
        /// </summary>
        [EnumMember(Value = "youtube")]
        Youtube,

        /// <summary>
        ///  type of social facebook
        /// </summary>
        [EnumMember(Value = "facebook")]
        FaceBook,
    }

    /// <summary>
    /// type of social (youtube/facebook).
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LiveStatus
    {
        /// <summary>
        ///  type of social youtube
        /// </summary>
        [EnumMember(Value = "init")]
        Init,

        /// <summary>
        ///  type of social youtube
        /// </summary>
        [EnumMember(Value = "start")]
        Start,

        /// <summary>
        ///  type of social youtube
        /// </summary>
        [EnumMember(Value = "stop")]
        Stop,

        /// <summary>
        ///  type of social youtube
        /// </summary>
        [EnumMember(Value = "error")]
        Error,

        /// <summary>
        ///  type of social youtube
        /// </summary>
        [EnumMember(Value = "in-process")]
        InProcess,

        /// <summary>
        ///  type of social youtube
        /// </summary>
        [EnumMember(Value = "not-streaming")]
        NotStreaming,
    }
}