namespace Uiza.Net.Configuration
{
    /// <summary>
    ///
    /// </summary>
    public static class UizaConfiguration
    {
        /// <summary>
        ///
        /// </summary>
        private static string apiKey;

        /// <summary>
        ///
        /// </summary>
        private static string appId;

        /// <summary>
        ///
        /// </summary>
        static UizaConfiguration()
        {
        }

        /// <summary>
        /// Get Configuration Api Key
        /// </summary>
        /// <returns></returns>
        internal static string GetApiKey() => apiKey;


        /// <summary>
        /// Setup new API key
        /// </summary>
        /// <param name="newApiKey"></param>
        public static void SetApiKey(string newApiKey) => apiKey = newApiKey;

        /// <summary>
        ///
        /// </summary>
        internal static string ApiBase
        {
            get
            {
                return Constants.DEFAULT_DOMAIN;
            }
        }


        internal static string AppId
        {
            get
            {
                return appId;
            }
        }

        /// <summary>
        /// Setup new Workspace API Domain
        /// </summary>
        /// <param name="newAppId"></param>
        public static void SetAppId(string newAppId) => appId = newAppId;

        /// <summary>
        /// Setup Uiza Enviroment
        /// </summary>
        /// <param name="options"></param>
        public static void SetupUiza(UizaConfigOptions options)
        {
            apiKey = options.ApiKey;
            appId = options.AppId;
        }
    }
}