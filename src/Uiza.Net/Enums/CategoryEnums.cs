using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Uiza.Net.Enums
{
    /// <summary>
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CategoryTypes
    {
        /// <summary>
        /// Types of category : tag
        /// </summary>
        [EnumMember(Value = "tag ")]
        Tag,

        /// <summary>
        /// Types of category : playlist
        /// </summary>
        [EnumMember(Value = "playlist")]
        PlayList,

        /// <summary>
        /// Types of category : folder
        /// </summary>
        [EnumMember(Value = "folder")]
        Folder,

        /// <summary>
        /// Types of category : category
        /// </summary>
        [EnumMember(Value = "category")]
        Category,
    }
}