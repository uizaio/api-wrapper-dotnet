using Newtonsoft.Json;

namespace Uiza.Net.Response
{
    /// <summary>
    ///
    /// </summary>
    public class EmbedData
    {
        /// <summary>
        ///
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("artist")]
        public string Artist { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("album_artist")]
        public string AlbumArtist { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("album")]
        public string Album { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("composer")]
        public string Composer { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("year")]
        public int Year { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("track")]
        public int Track { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("genre")]
        public string Genre { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("network")]
        public string Network { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("show")]
        public string Show { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("episode_id")]
        public string EpisodeId { get; set; }
    }
}