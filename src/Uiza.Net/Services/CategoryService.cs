using System;
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
        IRetrieve<UizaData>,
        IUpdate<UizaData, UpdateCategoryParameter>,
        IDelete<UizaData>,
        IRetrieveList<UizaData, RetrieveListParameter>,
        ICategoryService
    {
        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public virtual UizaData List(RetrieveListParameter param)
        {
            return this.GetRequest<UizaData>(Constants.ApiAction.CATEGORY, param);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public virtual UizaData Update(UpdateCategoryParameter param)
        {
            return this.PutRequest<UizaData>(Constants.ApiAction.CATEGORY, param);
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public virtual UizaData Delete(string categoryId)
        {
            return this.DeleteRequest<UizaData>(Constants.ApiAction.CATEGORY, new RetrieveItemParameter() { Id = categoryId });
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public UizaData Create(CreateCategoryParameter param)
        {
            return this.PostRequest<UizaData>(Constants.ApiAction.CATEGORY, param);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public UizaData Retrieve(string categoryId)
        {
            return this.GetRequest<UizaData>(Constants.ApiAction.CATEGORY, new RetrieveItemParameter() { Id = categoryId });
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