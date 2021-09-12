using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    /// <summary>
    /// Watch later
    /// </summary>
    public class WatchLater
    {
        /// <summary>
        /// Added
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("added")]
        public bool Added { get; set; }

        /// <summary>
        /// Options
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("options")]
        public List<string> Options { get; set; }

        /// <summary>
        /// Added time
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("added_time")]
        public DateTime? AddedTime { get; set; }

        /// <summary>
        /// URI
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
    }
}