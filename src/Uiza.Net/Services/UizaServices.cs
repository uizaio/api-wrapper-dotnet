using Uiza.Net.Services.Interface;

namespace Uiza.Net.Services
{
    /// <summary>
    /// Uiza Services
    /// </summary>
    public static class UizaServices
    {
        #region PUBLIC PROPERTIES

        /// <summary>
        /// Entity Service
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
        /// Category Service
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

        /// <summary>
        /// Storage Service
        /// </summary>
        public static IStorageService Storage
        {
            get
            {
                if (_storage == null)
                    _storage = new StorageService();
                return _storage;
            }
        }

        /// <summary>
        /// Callback Service
        /// </summary>
        public static ICallbackService Callback
        {
            get
            {
                if (_callback == null)
                    _callback = new CallbackService();
                return _callback;
            }
        }

        /// <summary>
        /// Live Service
        /// </summary>
        public static ILiveService Live
        {
            get
            {
                if (_live == null)
                    _live = new LiveService();
                return _live;
            }
        }

        /// <summary>
        /// Analytic Service
        /// </summary>
        public static IAnalyticService Analytic
        {
            get
            {
                if (_analytic == null)
                    _analytic = new AnalyticService();
                return _analytic;
            }
        }

        /// <summary>
        /// User Service
        /// </summary>
        public static IUserService User
        {
            get
            {
                if (_userService == null)
                    _userService = new UserService();
                return _userService;
            }
        }

        #endregion PUBLIC PROPERTIES

        #region PRIVATE PROPERTY

        private static IEntityService _entity;
        private static ICategoryService _category;
        private static IStorageService _storage;
        private static ICallbackService _callback;
        private static ILiveService _live;
        private static IAnalyticService _analytic;
        private static IUserService _userService;

        #endregion PRIVATE PROPERTY
    }
}