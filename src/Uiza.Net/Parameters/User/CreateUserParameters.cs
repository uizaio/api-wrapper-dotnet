using Newtonsoft.Json;
using System;
using Uiza.Net.Enums;

namespace Uiza.Net.Parameters
{
    /// <summary>
    /// CreatUserParameter
    /// </summary>
    public class CreatUserParameter : BaseParameter
    {
        /// <summary>
        /// Status of account ( 0 = de-active, 1 = active)
        /// </summary>
        [JsonProperty("status")]
        public UserStatus Status { get; set; }

        /// <summary>
        /// Username of account (used for login instead of email)
        /// </summary>
        [JsonProperty("username")]
        public string UserName { get; set; }

        /// <summary>
        /// Email (used for login instead of username)
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Password (from A to x , 6 to 25 characters)
        /// </summary>
        [JsonProperty("password")]
        public string PassWord { get; set; }

        /// <summary>
        /// Link of avatar ( suggest 300x300)
        /// </summary>
        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// Full name of user
        /// </summary>
        [JsonProperty("fullname")]
        public string FullName { get; set; }

        /// <summary>
        /// Date of birth (MM/DD/YYYY)
        /// </summary>
        [JsonProperty("dob")]
        public DateTime DOB { get; set; }

        /// <summary>
        /// Gender ( 0 = Male, 1 = Female)
        /// </summary>
        [JsonProperty("gender")]
        public GenderTypes Gender { get; set; }

        /// <summary>
        /// Set this account isAdmin or not (0 = Yes, 1 = No)
        /// </summary>
        [JsonProperty("isAdmin")]
        public int IsAdmin { get; set; }
    }
}