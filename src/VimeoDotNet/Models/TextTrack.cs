using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace VimeoDotNet.Models
{
    /// <summary>
    /// Text track
    /// </summary>
    public class TextTrack
    {
        /// <summary>
        /// URI
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Active
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("active")]
        public bool Active { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TextTrackType? Type { get; set; }

        /// <summary>
        /// Language
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("language")]
        public string Language { get; set; }

        /// <summary>
        /// Link
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("link")]
        public string Link { get; set; }

        /// <summary>
        /// Hls link
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("hls_link")]
        public string HlsLink { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    [PublicAPI]
    public enum TextTrackType
    {
        Captions,
        Chapters,
        Descriptions,
        Metadata,
        SubTitles
    }
}