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
        private static string apiBase;

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
                return apiBase;
            }
        }

        /// <summary>
        /// Setup new Workspace API Domain
        /// </summary>
        /// <param name="baseUrl"></param>
        public static void SetApiBase(string baseUrl) => apiBase = baseUrl;

        /// <summary>
        /// Setup Uiza Enviroment
        /// </summary>
        /// <param name="options"></param>
        public static void SetupUiza(UizaConfigOptions options)
        {
            apiKey = options.ApiKey;
            apiBase = options.ApiBase;
        }
    }
}