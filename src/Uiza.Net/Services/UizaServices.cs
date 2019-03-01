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

        /// <summary>
        ///
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
        ///
        /// </summary>
        public static ICallbackService Callback
        {
            get
            {
                if (_storage == null)
                    _callback = new CallbackService();
                return _callback;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static ILiveStreaming Live
        {
            get
            {
                if (_liveStreaming == null)
                    _liveStreaming = new LiveStreamingServices();
                return _liveStreaming;
            }
        }

        /// <summary>
        /// 
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
        /// 
        /// </summary>
        public static IUserService User
        {
            get
            {
                if (_userService == null)
                    _userService = new UserServices();
                return _userService;
            }
        }

        #endregion PUBLIC PROPERTIES

        #region PRIVATE PROPERTY

        private static IEntityService _entity;
        private static ICategoryService _category;
        private static IStorageService _storage;
        private static ICallbackService _callback;
        private static ILiveStreaming _liveStreaming;
        private static IAnalyticService _analytic;
        private static IUserService _userService;
        #endregion PRIVATE PROPERTY
    }
}