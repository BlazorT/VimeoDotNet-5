using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    /// <summary>
    /// User stats
    /// </summary>
    public class UserStats
    {
        /// <summary>
        /// Videos
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("videos")]
        public int Videos { get; set; }

        /// <summary>
        /// Contacts
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("contacts")]
        public int Contacts { get; set; }

        /// <summary>
        /// Likes
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("likes")]
        public int Likes { get; set; }

        /// <summary>
        /// Albums
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("albums")]
        public int Albums { get; set; }

        /// <summary>
        /// Channels
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("channels")]
        public int Channels { get; set; }

        /// <summary>
        /// Followers
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("followers")]
        public int Followers { get; set; }

        /// <summary>
        /// Following
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("following")]
        public int Following { get; set; }
    }
}