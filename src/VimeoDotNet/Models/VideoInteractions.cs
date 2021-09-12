using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    /// <summary>
    /// Video interactions
    /// </summary>
    public class VideoInteractions
    {
        /// <summary>
        /// Watch later
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("watchlater")]
        public WatchLater WatchLater { get; set; }
    }
}