using Uiza.Net.Response;

namespace Uiza.Net.Services.Interface
{
    /// <summary>
    /// Delete Service Interface
    /// </summary>
    /// <typeparam name="R"></typeparam>
    public interface IDelete<R>
           where R : IUizaResponse
    {
        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        R Delete(string id);
    }
}