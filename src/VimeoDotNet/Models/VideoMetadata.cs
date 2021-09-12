using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    /// <summary>
    /// Video metadata
    /// </summary>
    public class VideoMetadata
    {
        /// <summary>
        /// Connections
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("connections")]
        public VideoConnections Connections { get; set; }

        /// <summary>
        /// Interactions
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("interactions")]
        public VideoInteractions Interactions { get; set; }
    }
}