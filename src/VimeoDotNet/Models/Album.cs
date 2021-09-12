using System.Text.RegularExpressions;
using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    /// <summary>
    /// Album model
    /// </summary>
    public class Album
    {
        /// <summary>
        /// URI
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("uri")]
        public string Uri { get; set; }

        /// <summary>
        /// User
        /// </summary>

        [PublicAPI]
        [JsonPropertyName("user")]
        public User User { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Link
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("link")]
        public string Link { get; set; }

        /// <summary>
        /// Duration
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("duration")]
        public int Duration { get; set; }

        /// <summary>
        /// CreatedTime
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("created_time")]
        public string CreatedTime { get; set; }

        /// <summary>
        /// Pictures
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("pictures")]
        public Pictures Pictures { get; set; }

        /// <summary>
        /// Privacy
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("privacy")]
        public Privacy Privacy { get; set; }

        /// <summary>
        /// Stats
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("stats")]
        public AlbumStats Stats { get; set; }

        /// <summary>
        /// Metadata
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("metadata")]
        public AlbumMetadata Metadata { get; set; }

        /// <summary>
        /// Return album id if exists
        /// </summary>
        /// <returns>AlbumId or null</returns>
        [PublicAPI]
        public long? GetAlbumId()
        {
            if (string.IsNullOrEmpty(Uri))
            {
                return null;
            }

            var match = RegexAlbumUri.Match(Uri);
            if (match.Success)
            {
                return long.Parse(match.Groups["albumId"].Value);
            }

            return null;
        }

        private static readonly Regex RegexAlbumUri = new Regex(@"/albums/(?<albumId>\d+)/?$");
    }
}