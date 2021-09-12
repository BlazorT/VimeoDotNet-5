using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    /// <summary>
    /// Comment model
    /// </summary>
    public class Comment
    {
        /// <summary>
        /// URI
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("uri")]
        public string Uri { get; set; }

        /// <summary>
        /// User
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("user")]
        public User User { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Link
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("link")]
        public string Link { get; set; }

        /// <summary>
        /// Created time
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("created_time")]
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// Comments
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("comments")]
        public List<Comment> Comments { get; set; }
    }
}