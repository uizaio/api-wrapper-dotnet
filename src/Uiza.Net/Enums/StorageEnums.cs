using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Uiza.Net.Enums
{
    /// <summary>
    /// Storage can be FTP or AWS S3. Allowed values: [S3, FTP]
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StorageInputTypes
    {
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
}