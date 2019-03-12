using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Uiza.Net.Enums;
using Uiza.Net.Response;

namespace Uiza.Net.Parameters
{
    /// <summary>
    ///
    /// </summary>
    public class CreateEntityParameter : BaseParameter
    {
        /// <summary>
        /// Name of entity
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Full description for entity (without max-length)
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Short description of entity (250 characters)
        /// </summary>
        [JsonProperty("shortDescription")]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Full URL of media file (direct public HTTP/HTTPS, FTP, AWS S3 acceptable). 
        /// Send empty string in case of integration using SDK upload to AWS
        /// </summary>
        [JsonProperty("url")]
        public string URL { get; set; }

        /// <summary>
        /// Type of URL (Allowed value: [ http, s3, ftp, s3-uiza ] ). 
        /// In case url is empty string, this must be s3-uiza
        /// </summary>
        [JsonProperty("inputType")]
        public EntityInputTypes InputType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("masterTaskId")]
        public string MasterTaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("standardTaskId")]
        public string StandardTaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("scheduledStartDate")]
        public string ScheduledStartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("scheduledEndDate")]
        public string ScheduledEndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("geoFiltering")]
        public string GeoFiltering { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("geoFilteringValue")]
        public string GeoFilteringValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("social")]
        public string Social { get; set; }

        /// <summary>
        /// Poster of entity
        /// </summary>
        [JsonProperty("poster")]
        public string Poster { get; set; }

        /// <summary>
        /// Thumbnail of entity
        /// </summary>
        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("type")]
        public EntityTypes Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("embedMetadata")]
        public EmbedData EmbedMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extendMetadataId")]
        public string ExtendMetadataId { get; set; }
    }
}