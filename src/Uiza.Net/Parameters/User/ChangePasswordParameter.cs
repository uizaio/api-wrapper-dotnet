using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Uiza.Net.Parameters
{
    /// <summary>
    /// 
    /// </summary>
    public class ChangePasswordParameter : RetrieveItemParameter
    {
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
