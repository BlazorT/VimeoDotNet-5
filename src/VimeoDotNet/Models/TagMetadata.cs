using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    public class TagMetadata
    {
        /// <summary>
        /// Tag connections
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("connections")]
        public TagMetadataConnections Connections { get; set; }
    }
}