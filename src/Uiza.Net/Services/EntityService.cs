using Uiza.Net.Parameters;
using Uiza.Net.Response;
using Uiza.Net.Services.Interface;

namespace Uiza.Net.Services
{
    /// <summary>
    ///
    /// </summary>
    public class EntityService : Service,
        ICreate<UizaData, CreateEntityParameter>,
        IRetrieve<UizaData>,
        IUpdate<UizaData, UpdateEntityParameter>,
        IDelete<UizaData>,
        IRetrieveList<UizaData, BaseParameter>,
        IEntityService
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public virtual UizaData Create(CreateEntityParameter param)
        {
            if (string.IsNullOrWhiteSpace(param.URL))
            {
                param.URL = string.Empty;
                param.InputType = Enums.EntityInputTypes.S3Uiza;
            }

            return this.PostRequest<UizaData>(Constants.ApiAction.ENTITY, param);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public virtual UizaData Delete(string entityId)
        {
            return this.DeleteRequest<UizaData>(Constants.ApiAction.ENTITY, new RetrieveItemParameter() { Id = entityId });
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public virtual UizaData GetEntityAWSUploadKey()
        {
            return this.GetRequest<UizaData>(Constants.ApiAction.AWS_UPLOAD_KEY);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public virtual UizaData GetEntityStatusPublish(string id)
        {
            return this.GetRequest<UizaData>(Constants.ApiAction.ENTITY_STATUS_PUBLISH, new RetrieveItemParameter() { Id = id });
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public virtual UizaData List(BaseParameter param)
        {
            return this.GetRequest<UizaData>(Constants.ApiAction.ENTITY, param);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public virtual UizaData PublishEntity(string entityId)
        {
            return this.PostRequest<UizaData>(Constants.ApiAction.ENTITY_PUBLISH, new RetrieveItemParameter() { Id = entityId });
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public virtual UizaData Retrieve(string entityId)
        {
            return this.GetRequest<UizaData>(Constants.ApiAction.ENTITY, new RetrieveItemParameter() { Id = entityId });
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="keyWord"></param>
        /// <returns></returns>
        public virtual UizaData SearchEntity(string keyWord)
        {
            return this.GetRequest<UizaData>(Constants.ApiAction.ENTITY_SEARCH, new SearchEntityParameter() { Keyword = keyWord });
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public virtual UizaData Update(UpdateEntityParameter param)
        {
            return this.PutRequest<UizaData>(Constants.ApiAction.ENTITY, param);
        }
    }
}