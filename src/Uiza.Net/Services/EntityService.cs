using System;
using System.Collections.Generic;
using System.Text;
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
        IUpdate<UizaData, BaseParameter>,
        IDelete<UizaData, BaseParameter>,
        IRetrieveList<UizaData, BaseParameter>,
        IEntityService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public UizaData Create(CreateEntityParameter param)
        {
            if (string.IsNullOrWhiteSpace(param.URL))
            {
                param.URL = string.Empty;
                param.InputType = Enum.EntityInputTypes.S3Uiza;
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
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public UizaData GetAWSUploadKey()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public UizaData GetStatusPublish()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public UizaData List(BaseParameter param)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public UizaData Publish()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public UizaData Retrieve(BaseParameter param)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public UizaData Update(BaseParameter param)
        {
            throw new NotImplementedException();
        }
    }
}
