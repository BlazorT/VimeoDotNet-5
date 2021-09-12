using System.Collections.Generic;
using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{

    public class Category
    {
        [PublicAPI]
        [JsonPropertyName( "uri")]
        public string Uri { get; set; }

        [PublicAPI]
        [JsonPropertyName( "name")]
        public string Name { get; set; }

        [PublicAPI]
        [JsonPropertyName("link")]
        public string Link { get; set; }

        [PublicAPI]
        [JsonPropertyName("parent")]
        public string Parent { get; set; }

        [PublicAPI]
        [JsonPropertyName( "top_level")]
        public bool TopLevel { get; set; }

        [PublicAPI]
        [JsonPropertyName( "pictures")]
        public Pictures Pictures { get; set; }

        [PublicAPI]
        [JsonPropertyName( "last_video_featured_time")]
        public string LastVideoFeaturedTime { get; set; }

        [PublicAPI]
        [JsonPropertyName( "metadata")]
        public AlbumMetadata MetaData { get; set; }

        [PublicAPI]
        [JsonPropertyName( "options")]
        public List<string> Options { get; set; }

        [PublicAPI]
        [JsonPropertyName( "total")]
        public int Total { get; set; }

        [PublicAPI]
        [JsonPropertyName( "subcategories")]
        public List<Subcategory> Subcategories { get; set; }

        [PublicAPI]
        [JsonPropertyName( "icon")]
        public Pictures Icon { get; set; }
    }
}