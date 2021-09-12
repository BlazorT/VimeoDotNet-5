using System;
using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    /// <summary>
    /// Album metadata
    /// </summary>
    [Serializable]
    public class AlbumMetadata
    {
        /// <summary>
        /// Connections
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("connections")]
        public AlbumConnections Connections { get; set; }
    }
}