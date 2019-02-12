using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Uiza.Net.Parameters.User
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateAnUserParameters : BaseParameter
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("userName")]
        public string UserName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("password")]
        public string PassWord { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("avatar")]
        public string Avatar { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fullName")]
        public string FullName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dob")]
        public DateTime DOB { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("gender")]
        public int Gender { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("isAdmin")]
        public int IsAdmin { get; set; }
    }
}
