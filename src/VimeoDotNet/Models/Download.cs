using System;
using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    /// <summary>
    /// Download model
    /// </summary>
    public class Download
    {
        /// <summary>
        /// Quality
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("quality")]
        public string Quality { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Width
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("width")]
        public int Width { get; set; }

        /// <summary>
        /// Height
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("height")]
        public int Height { get; set; }

        /// <summary>
        /// File size
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("size")]
        public long Size { get; set; }

        /// <summary>
        /// Expires
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("expires")]
        public DateTime? Expires { get; set; }

        /// <summary>
        /// Link
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("link")]
        public string Link { get; set; }
    }
}