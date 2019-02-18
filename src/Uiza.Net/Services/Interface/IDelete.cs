using System;
using System.Collections.Generic;
using System.Text;
using Uiza.Net.Parameters;
using Uiza.Net.Response;

namespace Uiza.Net.Services.Interface
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="R"></typeparam>
    public interface IDelete<R>
           where R : IUizaResponse
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        R Delete(string id);
    }
}
