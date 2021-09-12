using System.Collections.Generic;
using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    /// <summary>
    /// User pictures
    /// </summary>
    public class Pictures
    {
        /// <summary>
        /// URI
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Active
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("active")]
        public bool Active { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Sizes
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("sizes")]
        public List<Size> Sizes { get; set; }

        /// <summary>
        /// Resources key
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("resource_key")]
        public string ResourceKey { get; set; }
    }
}