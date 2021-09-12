using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using VimeoDotNet.Helpers;

namespace VimeoDotNet.Models
{
    /// <summary>
    /// Embed presets
    /// </summary>
    public class EmbedPresets
    {
        /// <summary>
        /// Id
        /// </summary>
        [PublicAPI]
        public long? Id => ModelHelpers.ParseModelUriId(Uri);

        /// <summary>
        /// URI
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Settings
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("settings")]
        public PresetSettings Settings { get; set; }
    }
}