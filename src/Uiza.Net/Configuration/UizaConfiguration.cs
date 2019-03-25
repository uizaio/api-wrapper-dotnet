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
        private static string authorization;

        /// <summary>
        ///
        /// </summary>
        private static string workspaceApiDomain;

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
        internal static string GetAuthorization() => authorization;

        /// <summary>
        /// Setup new API key
        /// </summary>
        /// <param name="newApiKey"></param>
        public static void SetAuthorization(string newApiKey) => authorization = newApiKey;

        /// <summary>
        ///
        /// </summary>
        internal static string WorkspaceApiDomain
        {
            get
            {
                return workspaceApiDomain;
            }
        }

        /// <summary>
        /// Setup new Workspace API Domain
        /// </summary>
        /// <param name="workspaceApiDomain"></param>
        public static void SetWorkspaceApiDomain(string workspaceApiDomain) => UizaConfiguration.workspaceApiDomain = workspaceApiDomain;

        /// <summary>
        /// Setup Uiza Enviroment
        /// </summary>
        /// <param name="options"></param>
        public static void SetupUiza(UizaConfigOptions options)
        {
            authorization = options.Authorization;
            workspaceApiDomain = options.WorkspaceApiDomain;
        }
    }
}