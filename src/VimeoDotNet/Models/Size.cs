using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace VimeoDotNet.Models
{
    /// <summary>
    /// Size
    /// </summary>
    public class Size
    {
        /// <summary>
        /// The width of the image.
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("width")]
        public int Width { get; set; }

        /// <summary>
        /// The height of the image.
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("height")]
        public int Height { get; set; }

        /// <summary>
        /// The direct link to the image.
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("link")]
        public string Link { get; set; }
        
        /// <summary>
        /// The direct link to the image with a play button overlay.
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("link_with_play_button")]
        public string LinkWithPlayButton { get; set; }
    }
}