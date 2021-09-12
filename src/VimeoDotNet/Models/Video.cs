using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using JetBrains.Annotations;
using System.Text.Json;
using VimeoDotNet.Enums;
using VimeoDotNet.Helpers;

namespace VimeoDotNet.Models
{
    /// <summary>
    /// Video
    /// </summary>
    public class Video
    {
        private static readonly IDictionary<string, string> StatusMappings = new Dictionary<string, string>
        {
            {"uploading_error", "UploadError"}
        };

        /// <summary>
        /// Id
        /// </summary>
        public long? Id => ModelHelpers.ParseModelUriId(Uri);

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
        /// Review link
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("review_link")]
        public string ReviewLink { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Embed presets
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("embed_presets")]
        public EmbedPresets EmbedPresets { get; set; }

        /// <summary>
        /// Duration
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("duration")]
        public int Duration { get; set; }

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
        /// Created time
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("created_time")]
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// Modified time
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("modified_time")]
        public DateTime ModifiedTime { get; set; }

        /// <summary>
        /// Privacy
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("privacy")]
        public Privacy Privacy { get; set; }

        /// <summary>
        /// Pictures
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("pictures")]
        public Pictures Pictures { get; set; }

        /// <summary>
        /// Files
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("files")]
        public List<File> Files { get; set; }

        /// <summary>
        /// Download
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("download")]
        public List<Download> Download { get; set; }

        /// <summary>
        /// Tags
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("tags")]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// Stats
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("stats")]
        public VideoStats Stats { get; set; }

        /// <summary>
        /// Metadata
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("metadata")]
        public VideoMetadata Metadata { get; set; }

        /// <summary>
        /// Embed
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("embed")]
        public Embed Embed { get; set; }

        /// <summary>
        /// Video status
        /// </summary>
        [PublicAPI]
        public VideoStatusEnum VideoStatus
        {
            get => ModelHelpers.GetEnumValue<VideoStatusEnum>(Status, StatusMappings);
            set => Status = ModelHelpers.GetEnumString(value, StatusMappings);
        }

        /// <summary>
        /// Mobile video link
        /// </summary>
        [PublicAPI]
        public string MobileVideoLink => GetFileQualityUrl(FileQualityEnum.Mobile, false);

        /// <summary>
        /// Mobile video secure link
        /// </summary>
        [PublicAPI]
        public string MobileVideoSecureLink => GetFileQualityUrl(FileQualityEnum.Mobile, true);

        /// <summary>
        /// Standard video link
        /// </summary>
        [PublicAPI]
        public string StandardVideoLink => GetFileQualityUrl(FileQualityEnum.Standard, false);

        /// <summary>
        /// Standard video secure link
        /// </summary>
        [PublicAPI]
        public string StandardVideoSecureLink => GetFileQualityUrl(FileQualityEnum.Standard, true);

        /// <summary>
        /// High definition video link
        /// </summary>
        [PublicAPI]
        public string HighDefinitionVideoLink => GetFileQualityUrl(FileQualityEnum.HighDefinition, false);

        /// <summary>
        /// High definition video secure link
        /// </summary>
        [PublicAPI]
        public string HighDefinitionVideoSecureLink => GetFileQualityUrl(FileQualityEnum.HighDefinition, true);

        /// <summary>
        /// Streaming video link
        /// </summary>
        [PublicAPI]
        public string StreamingVideoLink => GetFileQualityUrl(FileQualityEnum.Streaming, false);

        /// <summary>
        /// Streaming video secure link
        /// </summary>
        [PublicAPI]
        public string StreamingVideoSecureLink => GetFileQualityUrl(FileQualityEnum.Streaming, true);

        private string GetFileQualityUrl(FileQualityEnum quality, bool secureLink)
        {
            if (Files == null || Files.Count == 0)
            {
                return null;
            }

            var match = Files.FirstOrDefault(f => f.FileQuality == quality);
            if (match == null)
            {
                return null;
            }

            return secureLink ? match.LinkSecure : match.Link;
        }
    }
}