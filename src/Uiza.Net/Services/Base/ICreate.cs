using Uiza.Net.Parameters;
using Uiza.Net.Response;

namespace Uiza.Net.Services.Interface
{
    /// <summary>
    /// Create Service Interface
    /// </summary>
    public interface ICreate<R, P>
        where R : IUizaResponse
        where P : IBaseParameter
    {
        /// <summary>
        /// Create
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        R Create(P param);
    }
}