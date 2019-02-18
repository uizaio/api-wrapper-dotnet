using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Uiza.Net.Enums
{

    /// <summary>
    /// 
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CategoryTypes
    {
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "folder")]
        Folder,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "playlist")]
        PlayList,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "tag ")]
        Tag
    }
}
