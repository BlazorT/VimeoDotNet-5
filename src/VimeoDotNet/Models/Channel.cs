using System.Collections.Generic;
using System.Text.RegularExpressions;
using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    public class Channel
    {
        [PublicAPI]
        [JsonPropertyName("uri")]
        public string Uri { get; set; }

        [PublicAPI]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [PublicAPI]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [PublicAPI]
        [JsonPropertyName("link")]
        public string Link { get; set; }

        [PublicAPI]
        [JsonPropertyName("created_time")]
        public string CreatedTime { get; set; }

        [PublicAPI]
        [JsonPropertyName("modified_time")]
        public string ModifiedTime { get; set; }

        [PublicAPI]
        [JsonPropertyName("user")]
        public User User { get; set; }

        [PublicAPI]
        [JsonPropertyName("tags")]
        public List<Tag> Tags { get; set; }
        
        [PublicAPI]
        [JsonPropertyName("pictures")]
        public Pictures Pictures { get; set; }

        [PublicAPI]
        [JsonPropertyName("header")]
        public Picture Header { get; set; }

        [PublicAPI]
        [JsonPropertyName("privacy")]
        public Privacy Privacy { get; set; }

        [PublicAPI]
        [JsonPropertyName("categories")]
        public List<Category> Categories { get; set; }

        [PublicAPI]
        [JsonPropertyName("metadata")]
        public ChannelMetadata Metadata { get; set; }

        [PublicAPI]
        [JsonPropertyName("resource_key")]
        public string ResourceKey { get; set; }


        [PublicAPI]
        public long? GetChannelId()
        {
            if (string.IsNullOrEmpty(Uri))
            {
                return null;
            }

            var match = RegexAlbumUri.Match(Uri);
            if (match.Success)
            {
                return long.Parse(match.Groups["channelid"].Value);
            }

            return null;
        }

        private static readonly Regex RegexAlbumUri = new Regex(@"/channels/(?<channelid>\d+)/?$");
    }
}