using Uiza.Net.Parameters;
using Uiza.Net.Response;

namespace Uiza.Net.Services.Interface
{
    /// <summary>
    /// Callback Service Interface
    /// </summary>
    public interface ICallbackService : IBaseServices,
        ICreate<UizaData, CreateCallbackParameter>,
        IRetrieve<UizaData, string>,
        IUpdate<UizaData, UpdateCallbackParameter>,
        IDelete<UizaData>
    {
    }
}