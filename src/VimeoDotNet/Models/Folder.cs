using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    public class Folder
    {
        /// <summary>
        /// User
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("user")]
        public User User { get; set; }

        /// <summary>
        /// Created time
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("created_time")]
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// Modified time
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("modified_time")]
        public DateTime ModifiedTime { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Privacy
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("privacy")]
        public Privacy Privacy { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("resource_key")]
        public string ResourceKey { get; set; }

        /// <summary>
        /// URI
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("uri")]
        public string Uri { get; set; }

        /// <summary>
        /// URI
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("link")]
        public string Link { get; set; }
    }
}
