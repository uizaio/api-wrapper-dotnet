﻿using Uiza.Net.Parameters;
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

            return this.PostRequest<UizaData>(Constants.ApiAction.Entity, param);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public UizaData Delete(string entityId)
        {
            return this.DeleteRequest<UizaData>(Constants.ApiAction.Entity, new RetrieveItemParameter() { Id = entityId });
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public UizaData GetEntityAWSUploadKey()
        {
            return this.GetRequest<UizaData>(Constants.ApiAction.AwsUploadKey);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public UizaData GetEntityStatusPublish(string id)
        {
            return this.GetRequest<UizaData>(Constants.ApiAction.EntityStatusPublish, new RetrieveItemParameter() { Id = id });
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
        public UizaData PublishEntity(string entityId)
        {
            return this.PostRequest<UizaData>(Constants.ApiAction.EntityPublish, new RetrieveItemParameter() { Id = entityId });
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public UizaData Retrieve(string entityId)
        {
            return this.GetRequest<UizaData>(Constants.ApiAction.Entity, new RetrieveItemParameter() { Id = entityId });
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="keyWord"></param>
        /// <returns></returns>
        public UizaData SearchEntity(string keyWord)
        {
            return this.GetRequest<UizaData>(Constants.ApiAction.EntitySearch, new SearchEntityParameter() { Keyword = keyWord });
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