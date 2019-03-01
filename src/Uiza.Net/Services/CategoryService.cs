using Uiza.Net.Parameters;
using Uiza.Net.Response;
using Uiza.Net.Services.Interface;
using Uiza.Net.Utility;

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
            param.DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.CATEGORY.CREATE);
            return this.PostRequest<UizaData>(Constants.ApiAction.CATEGORY, param);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public UizaData CreateRelation(CategoryRelationParameter param)
        {
            param.DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.CATEGORY.CREATE_CATEGORY_RELATION);
            return this.PostRequest<UizaData>(Constants.ApiAction.CATEGORY_RELATION, param);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public UizaData Delete(string categoryId)
        {
            return this.DeleteRequest<UizaData>(Constants.ApiAction.CATEGORY, new RetrieveItemParameter()
            {
                Id = categoryId,
                DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.CATEGORY.DELETE)
            });
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public UizaData DeleteRelation(CategoryRelationParameter param)
        {
            param.DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.CATEGORY.DELETE_CATEGORY_RELATION);
            return this.DeleteRequest<UizaData>(Constants.ApiAction.CATEGORY_RELATION, param);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public UizaData List(BaseParameter param)
        {
            param.DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.CATEGORY.LIST);
            return this.GetRequest<UizaData>(Constants.ApiAction.CATEGORY, param);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public UizaData Retrieve(string categoryId)
        {
            return this.GetRequest<UizaData>(Constants.ApiAction.CATEGORY, new RetrieveItemParameter()
            {
                Id = categoryId,
                DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.CATEGORY.RETRIEVE)
            });
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public UizaData Update(UpdateCategoryParameter param)
        {
            param.DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.CATEGORY.UPDATE);
            return this.PutRequest<UizaData>(Constants.ApiAction.CATEGORY, param);
        }
    }
}