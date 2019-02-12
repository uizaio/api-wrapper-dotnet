using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Uiza.Net.Parameters;
using Uiza.Net.Response;
using Uiza.Net.Services.Interface;

namespace Uiza.Net.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class CategoryService : Service, 
        ICreate<UizaData, CreateCategoryParameter>,
        IRetrieve<UizaData, RetrieveItemParameter>,
        IUpdate<UizaData, UpdateCategoryParameter>,
        IDelete<UizaData, RetrieveItemParameter>,
        IRetrieveList<UizaData, RetrieveListParameter>,
        ICategoryService
    {
       
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual UizaData List(RetrieveListParameter param)
        {
            return this.GetRequest<UizaData>(Constants.ApiAction.Category, param);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual UizaData Update(UpdateCategoryParameter param)
        {
            return this.PutRequest<UizaData>(Constants.ApiAction.Category, param);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual UizaData Delete(RetrieveItemParameter param)
        {
            return this.DeleteRequest<UizaData>(Constants.ApiAction.Category, param);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public UizaData Create(CreateCategoryParameter param)
        {
            return this.PostRequest<UizaData>(Constants.ApiAction.Category, param);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public UizaData Retrieve(RetrieveItemParameter param)
        {
            return this.GetRequest<UizaData>(Constants.ApiAction.Category, param);
        }

        /// <summary>
        /// 
        /// </summary>
        public void CreateRelation()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        public void DeleteRelation()
        {
            throw new NotImplementedException();
        }
    }
}
