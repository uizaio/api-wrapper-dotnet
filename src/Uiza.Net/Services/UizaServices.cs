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

        #endregion


        #region PRIVATE PROPERTY
        private static IEntityService _entity;
        #endregion
    }
}
