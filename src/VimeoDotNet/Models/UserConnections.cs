using System.Text.Json.Serialization;
using JetBrains.Annotations;
using System.Text.Json;

namespace VimeoDotNet.Models
{
    /// <summary>
    /// User connections entry
    /// </summary>
    public class UserConnections
    {
        /// <summary>
        /// Activities
        /// </summary>
        [PublicAPI]
        [JsonPropertyName( "activities")]
        public UserConnectionsEntry Activities { get; set; }

        /// <summary>
        /// Albums
        /// </summary>
        [PublicAPI]
        [JsonPropertyName( "albums")]
        public UserConnectionsEntry Albums { get; set; }

        /// <summary>
        /// Channels
        /// </summary>
        [PublicAPI]
        [JsonPropertyName( "channels")]
        public UserConnectionsEntry Channels { get; set; }

        /// <summary>
        /// Feed
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("feed")]
        public UserConnectionsEntry Feed { get; set; }

        /// <summary>
        /// Followers
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("followers")]
        public UserConnectionsEntry Followers { get; set; }

        /// <summary>
        /// Following
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("following")]
        public UserConnectionsEntry Following { get; set; }

        /// <summary>
        /// Groups
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("groups")]
        public UserConnectionsEntry Groups { get; set; }

        /// <summary>
        /// Likes
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("likes")]
        public UserConnectionsEntry Likes { get; set; }

        /// <summary>
        /// Portfolios
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("portfolios")]
        public UserConnectionsEntry Portfolios { get; set; }

        /// <summary>
        /// Videos
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("videos")]
        public UserConnectionsEntry Videos { get; set; }

        /// <summary>
        /// Watch later
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("watchlater")]
        public UserConnectionsEntry Watchlater { get; set; }
    }
}