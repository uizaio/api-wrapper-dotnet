using Uiza.Net.Parameters;
using Uiza.Net.Response;

namespace Uiza.Net.Services.Interface
{
    /// <summary>
    ///
    /// </summary>
    /// <typeparam name="R"></typeparam>
    /// <typeparam name="P"></typeparam>
    public interface IUpdate<R, P>
         where R : IUizaResponse
         where P : IBaseParameter
    {
        ///
        R Update(P param);
    }
}