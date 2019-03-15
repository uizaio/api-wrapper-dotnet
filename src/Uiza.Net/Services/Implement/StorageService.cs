using Uiza.Net.Parameters;
using Uiza.Net.Response;
using Uiza.Net.Services.Interface;
using Uiza.Net.Utility;

namespace Uiza.Net.Services
{
    /// <summary>
    ///
    /// </summary>
    internal class StorageService : Service, IStorageService
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public virtual UizaData Add(AddStorageParameter param)
        {
            param.DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.STORAGE.ADD);
            return this.PostRequest<UizaData>(Constants.ApiAction.STORAGE, param);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="storageId"></param>
        /// <returns></returns>
        public virtual UizaData Remove(string storageId)
        {
            return this.DeleteRequest<UizaData>(Constants.ApiAction.STORAGE, new RetrieveItemParameter()
            {
                Id = storageId,
                DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.STORAGE.REMOVE)
            });
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="storageId"></param>
        /// <returns></returns>
        public virtual UizaData Retrieve(string storageId)
        {
            return this.GetRequest<UizaData>(Constants.ApiAction.STORAGE, new RetrieveItemParameter()
            {
                Id = storageId,
                DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.STORAGE.RETRIEVE)
            });
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public virtual UizaData Update(UpdateStorageParameter param)
        {
            param.DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.STORAGE.UPDATE);
            return this.PutRequest<UizaData>(Constants.ApiAction.STORAGE, param);
        }
    }
}