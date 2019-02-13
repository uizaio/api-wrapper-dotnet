using System;
using System.Collections.Generic;
using System.Text;
using Uiza.Net.Response;

namespace Uiza.Net.Services.Interface
{
    /// <summary>
    /// 
    /// </summary>
    public interface IEntityService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        UizaData Publish();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        UizaData GetStatusPublish();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        UizaData GetAWSUploadKey();
    }
}
