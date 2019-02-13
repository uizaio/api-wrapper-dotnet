using System;
using System.Collections.Generic;
using System.Text;

namespace Uiza.Net.Parameters
{
    /// <summary>
    /// 
    /// </summary>
    public interface IBaseParameter
    {
        /// <summary>
        /// 
        /// </summary>
        Dictionary<string, object> ExtraParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        void AddExtraParam(string key, object value);
    }
}
