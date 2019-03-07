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