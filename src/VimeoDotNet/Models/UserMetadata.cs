
using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    /// <summary>
    /// User  metadata
    /// </summary>
    public class UserMetadata
    {
        /// <summary>
        /// Connections
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("connections")]
        public UserConnections Connections { get; set; }

        /// <summary>
        /// Interactions
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("interactions")]
        public UserInteractions Interactions { get; set; }

        /// <summary>
        /// Follower
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("follower")]
        public Follower Follower { get; set; }
    }
}