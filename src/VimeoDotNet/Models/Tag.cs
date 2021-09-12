using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    /// <summary>
    /// Tag
    /// </summary>
    public class Tag
    {
        /// <summary>
        /// Id
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("tag")]
        public string Id { get; set; }


        /// <summary>
        /// URI
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Canonical
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("canonical")]
        public string Canonical { get; set; }

        /// <summary>
        /// Metadata
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("metadata")]
        public TagMetadata Metadata { get; set; }
    }
}