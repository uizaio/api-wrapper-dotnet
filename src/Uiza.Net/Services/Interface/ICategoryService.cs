using Uiza.Net.Parameters;
using Uiza.Net.Response;

namespace Uiza.Net.Services.Interface
{
    /// <summary>
    /// Category Service Interface
    /// </summary>
    public interface ICategoryService : IBaseServices,
        ICreate<UizaData, CreateCategoryParameter>,
        IRetrieve<UizaData, string>,
        IUpdate<UizaData, UpdateCategoryParameter>,
        IDelete<UizaData>
    {
        /// <summary>
        /// Add relation for entity and category
        /// </summary>
        /// <returns></returns>
        UizaData CreateRelation(CategoryRelationParameter param);

        /// <summary>
        /// Delete relation for entity and category
        /// </summary>
        /// <returns></returns>
        UizaData DeleteRelation(CategoryRelationParameter param);

        /// <summary>
        /// Get all category
        /// </summary>
        /// <returns></returns>
        UizaData List();
    }
}
