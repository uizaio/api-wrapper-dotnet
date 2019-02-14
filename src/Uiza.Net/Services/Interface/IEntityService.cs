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
        UizaData Publish(BaseParameter param);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        UizaData GetStatusPublish(BaseParameter param);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        UizaData GetAWSUploadKey();
    }
}