﻿using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    /// <summary>
    /// Upload status
    /// </summary>
    public class UploadStatus
    {
        /// <summary>
        /// State
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// Progress
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("progress")]
        public int Progress { get; set; }

        /// <summary>
        /// Message
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}