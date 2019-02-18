using System;
using System.Collections.Generic;
using System.Text;
using Uiza.Net.Services.Interface;

namespace Uiza.Net.Services
{
    /// <summary>
    /// 
    /// </summary>
    public static class UizaServices
    {
        #region PUBLIC PROPERTIES

        /// <summary>
        /// 
        /// </summary>
        public static IEntityService Entity
        {
            get
            {
                if (_entity == null)
                    _entity = new EntityService();
                return _entity;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        public static ICategoryService Category
        {
            get
            {
                if (_category == null)
                    _category = new CategoryService();
                return _category;
            }
        }

        #endregion


        #region PRIVATE PROPERTY
        private static IEntityService _entity;
        private static ICategoryService _category;
        #endregion
    }
}
