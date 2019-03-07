namespace Uiza.Net.Configuration
{
    /// <summary>
    ///
    /// </summary>
    public class UizaConfigOptions
    {
        /// <summary>
        /// Token get from API
        /// https://docs.uiza.io/#get-api-key
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Workspace API Domain
        /// </summary>
        public string ApiBase { get; set; }
    }
}