using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    /// <summary>
    /// Video connections
    /// </summary>
    public class VideoConnections
    {
        /// <summary>
        /// Comments
        /// </summary>
        [PublicAPI]
        [JsonPropertyName( "comments")]
        public VideoConnectionsEntry Comments { get; set; }

        /// <summary>
        /// Credits
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("credits")]
        public VideoConnectionsEntry Credits { get; set; }

        /// <summary>
        /// Likes
        /// </summary>
        [PublicAPI]
        [JsonPropertyName( "likes")]
        public VideoConnectionsEntry Likes { get; set; }

        /// <summary>
        /// Pictures
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("pictures")]
        public VideoConnectionsEntry Pictures { get; set; }

        /// <summary>
        /// Text tracks
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("texttracks")]
        public TextTracks Texttracks { get; set; }
    }
}