using Newtonsoft.Json;

namespace Uiza.Net.Response
{
    /// <summary>
    ///
    /// </summary>
    public class EmbedData
    {
        /// <summary>
        /// Title of video/audio
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Name of artist
        /// </summary>
        [JsonProperty("artist")]
        public string Artist { get; set; }

        /// <summary>
        /// Artist of album
        /// </summary>
        [JsonProperty("album_artist")]
        public string AlbumArtist { get; set; }

        /// <summary>
        /// Name of album
        /// </summary>
        [JsonProperty("album")]
        public string Album { get; set; }

        /// <summary>
        /// Name of composer
        /// </summary>
        [JsonProperty("composer")]
        public string Composer { get; set; }

        /// <summary>
        /// Published year
        /// </summary>
        [JsonProperty("year")]
        public int Year { get; set; }

        /// <summary>
        /// Order of track in album
        /// </summary>
        [JsonProperty("track")]
        public int Track { get; set; }

        /// <summary>
        /// Genre
        /// </summary>
        [JsonProperty("genre")]
        public string Genre { get; set; }

        /// <summary>
        /// Video/Audio's description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Network channel
        /// </summary>
        [JsonProperty("network")]
        public string Network { get; set; }

        /// <summary>
        /// Name of show
        /// </summary>
        [JsonProperty("show")]
        public string Show { get; set; }

        /// <summary>
        /// Episode number
        /// </summary>
        [JsonProperty("episode_id")]
        public string EpisodeId { get; set; }
    }
}