using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    /// <summary>
    /// Preset logos
    /// </summary>
    public class PresetLogos
    {
        /// <summary>
        /// Vimeo
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("vimeo")]
        public bool Vimeo { get; set; }

        /// <summary>
        /// Custom
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("custom")]
        public bool Custom { get; set; }

        /// <summary>
        /// Sticky custom
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("sticky_custom")]
        public bool StickyCustom { get; set; }
    }
}