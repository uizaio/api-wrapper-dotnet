using Newtonsoft.Json;

namespace Uiza.Net.Parameters
{
    /// <summary>
    ///
    /// </summary>
    public class ChangePasswordParameter : BaseParameter
    {
        /// <summary>
        /// UserId
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Current password
        /// </summary>
        [JsonProperty("oldPassword")]
        public string OldPassWord { get; set; }

        /// <summary>
        /// New password (from a to Z, 6 to 25 characters)
        /// </summary>
        [JsonProperty("newPassword")]
        public string NewPassword { get; set; }
    }
}