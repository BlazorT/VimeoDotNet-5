using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    public class TagMetadataConnections
    {
        /// <summary>
        /// Video connections
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("videos")]
        public VideoConnectionsEntry Videos { get; set; }
    }
}