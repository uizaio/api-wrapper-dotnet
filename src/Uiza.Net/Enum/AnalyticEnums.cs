using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Uiza.Net.Enum
{
    /// <summary>
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MetricType
    {
        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "playback_failure_percentage")]
        PlaybackFailurePercentage,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "video_startup_time")]
        VideoStartupTime,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "player_startup_time")]
        PlayerStartupTime,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "page_load_time")]
        PageLoadTime,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "aggregate_startup_time")]
        AggregateStartupTime,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "seek_latency")]
        SeekLatency,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "exits_before_video_start")]
        ExitsBeforeVideoStart,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "rebuffer_percentage")]
        RebufferPercentage,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "rebuffer_frequency")]
        RebufferFrequency,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "rebuffer_duration")]
        RebufferDuration,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "rebuffer_count")]
        RebufferCount,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "upscale_percentage")]
        UpscalePercentage,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "downscale_percentage")]
        DownscalePercentage,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "max_upscale_percentage")]
        MaxUpscalePercentage,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "max_downscale_percentage")]
        MaxDownscalePercentage,
    }

    /// <summary>
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TypeFilter
    {
        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "country")]
        Country,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "device")]
        Device,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "title")]
        Title,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "player")]
        Player,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "os ")]
        Os
    }

    /// <summary>
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LineType
    {
        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "playback_failure_percentage")]//
        PlaybackFailurePercentage,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "video_startup_time")]//
        VideoStartupTime,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "aggregate_startup_time")]//
        AggregateStartupTime,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "exits_before_video_start")]//
        ExitsBeforeVideoStart,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "rebuffer_percentage")]//
        RebufferPercentage,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "rebuffer_frequency")]//
        RebufferFrequency,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "rebuffer_duration")]//
        RebufferDuration,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "rebuffer_count")]//
        RebufferCount,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "upscale_percentage")]//
        UpscalePercentage,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "downscale_percentage")]//
        DownscalePercentage,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "max_upscale_percentage")]//
        MaxUpscalePercentage,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "playback_failure_score")]
        PlaybackFailureScore,

        /// <summary>
        ///
        /// </summary>
        [EnumMember(Value = "max_downscale_percentage")]
        MaxDownscalePercentage,
    }
}