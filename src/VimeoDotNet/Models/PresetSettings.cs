using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    /// <summary>
    /// Preset settings
    /// </summary>
    public class PresetSettings
    {
        /// <summary>
        /// Buttons
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("buttons")]
        public PresetButtons Buttons { get; set; }

        /// <summary>
        /// Logos
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("logos")]
        public PresetLogos Logos { get; set; }

        /// <summary>
        /// Outro
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("outro")]
        public string Outro { get; set; }

        /// <summary>
        /// Portrait
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("portrait")]
        public string Portrait { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Byline
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("byline")]
        public string Byline { get; set; }

        /// <summary>
        /// Badge
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("badge")]
        public bool Badge { get; set; }

        /// <summary>
        /// Byline badge
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("byline_badge")]
        public bool BylineBadge { get; set; }

        /// <summary>
        /// Playbar
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("playbar")]
        public bool PlayBar { get; set; }

        /// <summary>
        /// Volume
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("volume")]
        public bool Volume { get; set; }

        /// <summary>
        /// Fullscreen button
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("fullscreen_button")]
        public bool FullscreenButton { get; set; }

        /// <summary>
        /// Scaling button
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("scaling_button")]
        public bool ScalingButton { get; set; }

        /// <summary>
        /// Autoplay
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("autoplay")]
        public bool AutoPlay { get; set; }

        /// <summary>
        /// Autopause
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("autopause")]
        public bool AutoPause { get; set; }

        /// <summary>
        /// Loop
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("loop")]
        public bool Loop { get; set; }

        /// <summary>
        /// Color
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("color")]
        public string Color { get; set; }

        /// <summary>
        /// Link
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("link")]
        public bool Link { get; set; }
    }
}