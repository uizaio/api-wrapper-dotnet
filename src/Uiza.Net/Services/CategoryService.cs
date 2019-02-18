using Uiza.Net.Parameters;
using Uiza.Net.Response;
using Uiza.Net.Services.Interface;

namespace Uiza.Net.Services
{
    internal class CategoryService : Service, ICategoryService
    {
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
        /// <param name="param"></param>
        /// <returns></returns>
        public UizaData CreateCategoryRelation(CategoryRelationParameter param)
        {
            return this.PostRequest<UizaData>(Constants.ApiAction.CATEGORY_RELATION, param);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public UizaData Delete(string categoryId)
        {
            return this.DeleteRequest<UizaData>(Constants.ApiAction.CATEGORY, new RetrieveItemParameter() { Id = categoryId });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public UizaData DeleteCategoryRelation(CategoryRelationParameter param)
        {
            return this.DeleteRequest<UizaData>(Constants.ApiAction.CATEGORY_RELATION, param);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public UizaData List(BaseParameter param)
        {
            return this.GetRequest<UizaData>(Constants.ApiAction.CATEGORY, param);
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
        /// <param name="param"></param>
        /// <returns></returns>
        public UizaData Update(UpdateCategoryParameter param)
        {
            return this.PutRequest<UizaData>(Constants.ApiAction.CATEGORY, param);
        }
    }
}
