using System;
using System.Collections.Generic;
using System.Text;
using Uiza.Net.Parameters;
using Uiza.Net.Response;

namespace Uiza.Net.Services.Interface
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICategoryService : IBaseServices,
        ICreate<UizaData, CreateCategoryParameter>,
        IRetrieve<UizaData>,
        IUpdate<UizaData, UpdateCategoryParameter>,
        IDelete<UizaData>,
        IRetrieveList<UizaData, BaseParameter>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        UizaData CreateCategoryRelation(CategoryRelationParameter param);


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        UizaData DeleteCategoryRelation(CategoryRelationParameter param);
    }
}
