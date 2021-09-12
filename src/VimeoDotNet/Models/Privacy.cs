using JetBrains.Annotations;
using System.Text.Json;
using VimeoDotNet.Enums;
using VimeoDotNet.Helpers;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    /// <summary>
    /// Privacy
    /// </summary>
    public class Privacy
    {
        /// <summary>
        /// View
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("view")]
        public string View { get; set; }

        /// <summary>
        /// Embed
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("embed")]
        public string Embed { get; set; }

        /// <summary>
        /// Download
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("download")]
        public bool Download { get; set; }

        /// <summary>
        /// Add
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("add")]
        public bool Add { get; set; }

        /// <summary>
        /// View privacy
        /// </summary>
        [PublicAPI]
        public VideoPrivacyEnum ViewPrivacy
        {
            get => ModelHelpers.GetEnumValue<VideoPrivacyEnum>(View);
            set => View = ModelHelpers.GetEnumString(value);
        }

        /// <summary>
        /// Embed privacy
        /// </summary>
        [PublicAPI]
        public VideoEmbedPrivacyEnum EmbedPrivacy
        {
            get => ModelHelpers.GetEnumValue<VideoEmbedPrivacyEnum>(Embed);
            set => Embed = ModelHelpers.GetEnumString(value);
        }
    }
}