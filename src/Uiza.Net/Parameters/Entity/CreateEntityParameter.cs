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
        ///
        /// </summary>
        [JsonProperty("name")]
        [Display(Name = "Name")]
        [Required(ErrorMessage = Constants.ErrorMessages.REQUIRED)]
        public string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("url")]
        [Display(Name = "URL")]
        [Required(AllowEmptyStrings = true, ErrorMessage = Constants.ErrorMessages.REQUIRED)]
        public string URL { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("inputType")]
        [Required(ErrorMessage = Constants.ErrorMessages.INPUT_TYPE_REQUIRED)]
        public EntityInputTypes InputType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("metadataId")]
        public string MetadataId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("shortDescription")]
        public string ShortDescription { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("poster")]
        public string Poster { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("metadataIds")]
        public List<string> MetadataIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("embedMetadata")]
        public EmbedData EmbedMetadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("extendMetadata")]
        public Dictionary<string, object> ExtendMetadata { get; set; }
    }
}