using Uiza.Net.Parameters;
using Uiza.Net.Response;

namespace Uiza.Net.Services.Interface
{
    /// <summary>
    ///
    /// </summary>
    public interface IEntityService
    {
        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        UizaData PublishEntity(string entityId);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        UizaData GetEntityStatusPublish(string entityId);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        UizaData GetEntityAWSUploadKey();

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        UizaData SearchEntity(string keyWord);
    }
}