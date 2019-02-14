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
        IRetrieve<UizaData, BaseParameter>,
        IUpdate<UizaData, UpdateEntityParameter>,
        IDelete<UizaData, BaseParameter>,
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

            return this.PostRequest<UizaData>(Constants.ApiAction.Entity, param);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public UizaData Delete(BaseParameter param)
        {
            return this.DeleteRequest<UizaData>(Constants.ApiAction.Entity, param);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public UizaData GetAWSUploadKey()
        {
            return this.GetRequest<UizaData>(Constants.ApiAction.AwsUploadKey);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public UizaData GetStatusPublish(BaseParameter param)
        {
            return this.GetRequest<UizaData>(Constants.ApiAction.EntityStatusPublish, param);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public UizaData List(BaseParameter param)
        {
            return this.GetRequest<UizaData>(Constants.ApiAction.Entity, param);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public UizaData Publish(BaseParameter param)
        {
            return this.PostRequest<UizaData>(Constants.ApiAction.EntityPublish, param);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public UizaData Retrieve(BaseParameter param)
        {
            return this.GetRequest<UizaData>(Constants.ApiAction.Entity, param);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public UizaData Search(BaseParameter param)
        {
            return this.GetRequest<UizaData>(Constants.ApiAction.EntitySearch, param);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public UizaData Update(UpdateEntityParameter param)
        {
            return this.PutRequest<UizaData>(Constants.ApiAction.Entity, param);
        }
    }
}