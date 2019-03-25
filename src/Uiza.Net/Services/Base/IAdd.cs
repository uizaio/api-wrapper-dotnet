using Uiza.Net.Parameters;
using Uiza.Net.Response;

namespace Uiza.Net.Services.Interface
{
    /// <summary>
    /// Add Service Interface
    /// </summary>
    /// <typeparam name="R"></typeparam>
    /// <typeparam name="P"></typeparam>
    public interface IAdd<R, P>
        where R : IUizaResponse
        where P : IBaseParameter
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        R Add(P param);
    }
}