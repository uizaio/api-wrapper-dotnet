using Uiza.Net.Parameters;
using Uiza.Net.Response;

namespace Uiza.Net.Services.Interface
{
    /// <summary>
    /// Entity Service Interface
    /// </summary>
    public interface IEntityService : IBaseServices,
        ICreate<UizaData, CreateEntityParameter>,
        IRetrieve<UizaData, string>,
        IUpdate<UizaData, UpdateEntityParameter>,
        IDelete<UizaData>,
        IRetrieveList<UizaData, BaseParameter>
    {
        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        UizaData Publish(string entityId);

        /// <summary>
        /// Publish entity to CDN, use for streaming
        /// </summary>
        /// <returns></returns>
        UizaData GetStatusPublish(string entityId);

        /// <summary>
        /// Get AWS upload key
        /// This API will be return the bucket temporary upload storage and key for upload 
        /// so that you can push your file to Uiza’s storage and get the link for URL upload and create entity
        /// </summary>
        /// <returns></returns>
        UizaData GetAWSUploadKey();

        /// <summary>
        /// Search entity base on keyword entered
        /// </summary>
        /// <returns></returns>
        UizaData Search(string keyWord);
    }
}