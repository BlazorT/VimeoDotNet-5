using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using VimeoDotNet.Enums;
using VimeoDotNet.Helpers;

namespace VimeoDotNet.Models
{
    /// <summary>
    /// User
    /// </summary>
    public class User
    {
        private static readonly IDictionary<string, string> AccountTypeMappings = new Dictionary<string, string>
        {
            {"pro_unlimited", "ProUnlimited"}
        };

        /// <summary>
        /// Id
        /// </summary>
        public long? Id => ModelHelpers.ParseModelUriId(Uri);

        /// <summary>
        /// URI
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Link
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("link")]
        public string Link { get; set; }

        /// <summary>
        /// Location
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("location")]
        public string Location { get; set; }

        /// <summary>
        /// Bio
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("bio")]
        public string Bio { get; set; }

        /// <summary>
        /// Created time
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("created_time")]
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// Account
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// Content filter
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("content_filter")]
        public string[] ContentFilter { get; set; }

        /// <summary>
        /// Pictures
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("pictures")]
        public Pictures Pictures { get; set; }

        /// <summary>
        /// Web sites
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("websites")]
        public List<Website> Websites { get; set; }

        /// <summary>
        /// Stats
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("stats")]
        public UserStats Stats { get; set; }

        /// <summary>
        /// Metadata
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("metadata")]
        public UserMetadata Metadata { get; set; }

        /// <summary>
        /// Upload quota
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("upload_quota")]
        public UserUploadQuota UploadQuota { get; set; }

        /// <summary>
        /// Account type
        /// </summary>
        [PublicAPI]
        public AccountTypeEnum AccountType
        {
            get => ModelHelpers.GetEnumValue<AccountTypeEnum>(Account, AccountTypeMappings);
            set => Account = ModelHelpers.GetEnumString(value);
        }
    }
}