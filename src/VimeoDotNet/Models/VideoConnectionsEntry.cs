﻿using System.Collections.Generic;
using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    /// <summary>
    /// Video connections entry
    /// </summary>
    public class VideoConnectionsEntry
    {
        /// <summary>
        /// URI
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Options
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("options")]
        public List<string> Options { get; set; }

        /// <summary>
        /// Total
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("total")]
        public int Total { get; set; }
    }
}