using Newtonsoft.Json;
using Uiza.Net.Enums;

namespace Uiza.Net.Parameters
{
    /// <summary>
    ///
    /// </summary>
    public class AddStorageParameter : BaseParameter
    {
        /// <summary>
        /// Name of the storage
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Host name of the server or IP address
        /// </summary>
        [JsonProperty("host")]
        public string Host { get; set; }

        /// <summary>
        /// Used port for FTP server. Normally will be 21
        /// </summary>
        [JsonProperty("port")]
        public int Port { get; set; }

        /// <summary>
        /// Storage can be FTP or AWS S3. Allowed values: [S3, FTP]
        /// </summary>
        [JsonProperty("storageType")]
        public StorageInputTypes? StorageType { get; set; }

        /// <summary>
        /// Account username
        /// </summary>
        [JsonProperty("username")]
        public string UserName { get; set; }

        /// <summary>
        /// Account password
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// Storage's description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}