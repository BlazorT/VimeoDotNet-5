using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using System.Text.Json;
using VimeoDotNet.Enums;
using VimeoDotNet.Helpers;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    /// <summary>
    /// File model
    /// </summary>
    public class File
    {
        private static readonly IDictionary<string, string> QualityMappings = new Dictionary<string, string>
        {
            {"mobile", "Mobile"},
            {"hd", "HighDefinition"},
            {"sd", "Standard"},
            {"hls", "Streaming"}
        };

        /// <summary>
        /// Quality
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("quality")]
        public string Quality { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Width
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("width")]
        public int Width { get; set; }

        /// <summary>
        /// Height
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("height")]
        public int Height { get; set; }

        /// <summary>
        /// File size
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("size")]
        public long Size { get; set; }

        /// <summary>
        /// Expires
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("expires")]
        public DateTime? Expires { get; set; }

        /// <summary>
        /// Link
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("link")]
        public string Link { get; set; }

        /// <summary>
        /// LinkSecure
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("link_secure")]
        public string LinkSecure { get; set; }

        /// <summary>
        /// FileQuality
        /// </summary>
        [PublicAPI]
        public FileQualityEnum FileQuality
        {
            get => ModelHelpers.GetEnumValue<FileQualityEnum>(Quality, QualityMappings);
            set => Quality = ModelHelpers.GetEnumString(value, QualityMappings);
        }
    }
}