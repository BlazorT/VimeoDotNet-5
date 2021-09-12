using System;
using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    /// <summary>
    /// Embed
    /// </summary>
    public class Embed
    {
        /// <summary>
        /// URI
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Html
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("html")]
        public string Html { get; set; }
    }
}
