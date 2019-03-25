using Uiza.Net.Response;

namespace Uiza.Net.Services.Interface
{
    /// <summary>
    /// Remove Service Interface
    /// </summary>
    /// <typeparam name="R"></typeparam>
    public interface IRemove<R>
        where R : IUizaResponse
    {
        /// <summary>
        /// Remove
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        R Remove(string id);
    }
}