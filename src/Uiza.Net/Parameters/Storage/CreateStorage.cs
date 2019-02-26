﻿using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Uiza.Net.Enums;

namespace Uiza.Net.Parameters
{
    /// <summary>
    ///
    /// </summary>
    public class CreateStorageParameter : BaseParameter
    {
        /// <summary>
        ///
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("host")]
        public string Host { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("port")]
        public int Port { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("storageType")]
        public StorageInputTypes StorageType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("username")]
        public string UserName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("awsAccessKey")]
        public string AwsAccessKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("awsSecretKey")]
        public string AwsSecretKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("prefix")]
        public string Prefix { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("bucket")]
        public string Bucket { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("region")]
        public string Region { get; set; }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}