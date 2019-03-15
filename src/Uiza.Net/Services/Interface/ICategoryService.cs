using Uiza.Net.Parameters;
using Uiza.Net.Response;

namespace Uiza.Net.Services.Interface
{
    /// <summary>
    ///
    /// </summary>
    public interface ICategoryService : IBaseServices,
        ICreate<UizaData, CreateCategoryParameter>,
        IRetrieve<UizaData, RetriveCategoryParameter>,
        IUpdate<UizaData, UpdateCategoryParameter>,
        IDelete<UizaData>
    {
        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        UizaData CreateRelation(CategoryRelationParameter param);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        UizaData DeleteRelation(CategoryRelationParameter param);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        UizaData List();
    }
}