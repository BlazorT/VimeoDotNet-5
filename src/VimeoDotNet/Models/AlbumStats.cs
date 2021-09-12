
using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    /// <summary>
    /// Album statistics
    /// </summary>
    public class AlbumStats
    {
        /// <summary>
        /// Videos
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("plays")]
        public int Plays { get; set; }
    }
}