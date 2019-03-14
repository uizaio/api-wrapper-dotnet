using Uiza.Net.Parameters;
using Uiza.Net.Response;
using Uiza.Net.Services.Interface;
using Uiza.Net.Utility;

namespace Uiza.Net.Services
{
    /// <summary>
    ///
    /// </summary>
    internal class EntityService : Service, IEntityService
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public virtual UizaData Create(CreateEntityParameter param)
        {
            param.DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.ENTITY.CREATE);
            return this.PostRequest<UizaData>(Constants.ApiAction.ENTITY, param);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public virtual UizaData Delete(string entityId)
        {
            return this.DeleteRequest<UizaData>(Constants.ApiAction.ENTITY, new RetrieveItemParameter()
            {
                Id = entityId,
                DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.ENTITY.DELETE)
            });
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public virtual UizaData GetAWSUploadKey()
        {
            return this.GetRequest<UizaData>(Constants.ApiAction.AWS_UPLOAD_KEY, new BaseParameter() { DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.ENTITY.GET_AWS_UPLOAD_KEY) });
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public virtual UizaData GetStatusPublish(string id)
        {
            return this.GetRequest<UizaData>(Constants.ApiAction.ENTITY_STATUS_PUBLISH, new RetrieveItemParameter()
            {
                Id = id,
                DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.ENTITY.GET_STATUS_PUBLISH)
            });
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public virtual UizaData List()
        {
            return this.GetRequest<UizaData>(Constants.ApiAction.ENTITY, new BaseParameter()
            {
                DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.ENTITY.LIST)
            });
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public virtual UizaData Publish(string entityId)
        {
            return this.PostRequest<UizaData>(Constants.ApiAction.ENTITY_PUBLISH, new RetrieveItemParameter()
            {
                Id = entityId,
                DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.ENTITY.PUBLISH_ENTITY_TO_CDN)
            });
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public virtual UizaData Retrieve(string entityId)
        {
            return this.GetRequest<UizaData>(Constants.ApiAction.ENTITY, new RetrieveItemParameter()
            {
                Id = entityId,
                DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.ENTITY.RETRIEVE)
            });
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public virtual UizaData Update(UpdateEntityParameter param)
        {
            param.DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.ENTITY.UPDATE);
            return this.PutRequest<UizaData>(Constants.ApiAction.ENTITY, param);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="keyWord"></param>
        /// <returns></returns>
        public virtual UizaData Search(string keyWord)
        {
            return this.GetRequest<UizaData>(Constants.ApiAction.ENTITY_SEARCH, new SearchEntityParameter()
            {
                Keyword = keyWord,
                DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.ENTITY.SEARCH)
            });
        }
    }
}