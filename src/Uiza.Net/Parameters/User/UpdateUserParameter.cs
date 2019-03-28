using Newtonsoft.Json;
using System;
using Uiza.Net.Enums;

namespace Uiza.Net.Parameters
{
    /// <summary>
    ///
    /// </summary>
    public class UpdateUserParameter : RetrieveItemParameter
    {
        /// <summary>
        /// Status of account ( 0 = de-active, 1 = active)
        /// </summary>
        [JsonProperty("status")]
        public UserStatus Status { get; set; }

        /// <summary>
        /// Username of account (used for login instead of email)
        /// </summary>
        [JsonProperty("name")]
        public string UserName { get; set; }

        /// <summary>
        /// Date of birth (MM/DD/YYYY)
        /// </summary>
        [JsonProperty("dob")]
        public DateTime DOB { get; set; }

        /// <summary>
        /// Link of avatar ( suggest 300x300)
        /// </summary>
        [JsonProperty("avatar")]
        public string Avatar { get; set; }

      
    }
}