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