using System;
using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    /// <summary>
    /// Like
    /// </summary>
    public class Like
    {
        /// <summary>
        /// Added
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("added")]
        public bool Added { get; set; }

        /// <summary>
        /// Added time
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("added_time")]
        public DateTime AddedTime { get; set; }

        /// <summary>
        /// URI
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
    }
}