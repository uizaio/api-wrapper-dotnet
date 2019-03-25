using Uiza.Net.Parameters;
using Uiza.Net.Response;

namespace Uiza.Net.Services.Interface
{
    /// <summary>
    /// Storage Service Interface
    /// </summary>
    public interface IStorageService : IBaseServices,
        IAdd<UizaData, AddStorageParameter>,
        IRetrieve<UizaData, string>,
        IUpdate<UizaData, UpdateStorageParameter>,
        IRemove<UizaData>
    {
    }
}