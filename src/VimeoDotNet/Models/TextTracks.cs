using System.Collections.Generic;
using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    /// <summary>
    /// Text tracks
    /// </summary>
    public class TextTracks
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
        /// Content
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("data")]
        public List<TextTrack> Data { get; set; }

        /// <summary>
        /// Total
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("total")]
        public string Total { get; set; }
    }
}