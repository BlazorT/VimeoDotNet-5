using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    /// <summary>
    /// Album connections
    /// </summary>
    public class AlbumConnections
    {
        /// <summary>
        /// Videos
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("videos")]
        public AlbumConnectionsEntry Videos { get; set; }
    }
}