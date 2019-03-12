using Uiza.Net.Parameters;
using Uiza.Net.Response;

namespace Uiza.Net.Services.Interface
{
    /// <summary>
    ///
    /// </summary>
    public interface IEntityService : IBaseServices,
        ICreate<UizaData, CreateEntityParameter>,
        IRetrieve<UizaData>,
        IUpdate<UizaData, UpdateEntityParameter>,
        IDelete<UizaData>
    {
        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        UizaData Publish(string entityId);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        UizaData GetStatusPublish(string entityId);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        UizaData GetAWSUploadKey();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        UizaData List();
    }
}