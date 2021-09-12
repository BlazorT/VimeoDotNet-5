using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    /// <summary>
    /// Domain for embedding a video
    /// </summary>
    public class DomainForEmbedding
    {
        /// <summary>
        /// Domain name
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// Whether HD quality is allowed
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("allow_hd")]
        public bool AllowHighDefinition { get; set; }

        /// <summary>
        /// URI of this resource
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
    }
}
