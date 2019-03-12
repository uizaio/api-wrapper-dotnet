using Uiza.Net.Parameters;
using Uiza.Net.Response;

namespace Uiza.Net.Services
{
    /// <summary>
    ///
    /// </summary>
    /// <typeparam name="R"></typeparam>
    ///  /// <typeparam name="P"></typeparam>
    public interface IRetrieve<R, P>
         where R : IUizaResponse
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        R Retrieve(P param);
    }
}