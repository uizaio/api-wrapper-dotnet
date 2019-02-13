using System;
using System.Collections.Generic;
using System.Text;

namespace Uiza.Net.Response
{
    /// <summary>
    /// 
    /// </summary>
    public interface IUizaResponse
    {
        /// <summary>
        /// 
        /// </summary>
        int Version { get; set; }
        /// <summary>
        /// 
        /// </summary>
        string DateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        string policy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        string RequestId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        string ServiceName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        string Message { get; set; }
        /// <summary>
        /// 
        /// </summary>
        int Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        dynamic MetaData { get; set; }
    }
}
