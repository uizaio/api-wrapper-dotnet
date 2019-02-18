using System;
using System.Collections.Generic;
using System.Text;
using Uiza.Net.Parameters;
using Uiza.Net.Response;

namespace Uiza.Net.Services
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="R"></typeparam>
    public interface IRetrieve<R>
         where R : IUizaResponse
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        R Retrieve(string id);
    }
}
