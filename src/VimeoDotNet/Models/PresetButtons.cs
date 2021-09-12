using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    /// <summary>
    /// Preset buttons
    /// </summary>
    public class PresetButtons
    {
        /// <summary>
        /// Like
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("like")]
        public bool Like { get; set; }

        /// <summary>
        /// Watch later
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("watchlater")]
        public bool WatchLater { get; set; }

        /// <summary>
        /// Share
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("share")]
        public bool Share { get; set; }

        /// <summary>
        /// Embed
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("embed")]
        public bool Embed { get; set; }

        /// <summary>
        /// Vote
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("vote")]
        public bool Vote { get; set; }

        /// <summary>
        /// HD
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("hd")]
        public bool Hd { get; set; }
    }
}