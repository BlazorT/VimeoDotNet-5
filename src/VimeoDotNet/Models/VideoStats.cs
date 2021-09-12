
using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace VimeoDotNet.Models
{
    /// <summary>
    /// Video stats
    /// </summary>
    public class VideoStats
    {
        /// <summary>
        /// Plays
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("plays")]
        public int? Plays { get; set; }

        /// <summary>
        /// Likes
        /// </summary>
        [PublicAPI]
        [JsonPropertyName( "likes")]
        public int? Likes { get; set; }

        /// <summary>
        /// Comments
        /// </summary>
        [PublicAPI]
        [JsonPropertyName( "comments")]
        public int? Comments { get; set; }
    }
}