using System;
using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    /// <summary>
    /// Upload ticket quota
    /// </summary>
    public class UploadTicketQuota
    {
        /// <summary>
        /// SD
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("sd")]
        public bool Sd { get; set; }

        /// <summary>
        /// HD
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("hd")]
        public bool Hd { get; set; }

        /// <summary>
        /// Total space
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("total_space")]
        public long TotalSpace { get; set; }

        /// <summary>
        /// Space used
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("space_used")]
        public long SpaceUsed { get; set; }

        /// <summary>
        /// Free space
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("free_space")]
        public long FreeSpace { get; set; }

        /// <summary>
        /// Max file size
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("max_file_size")]
        public long MaxFileSize { get; set; }

        /// <summary>
        /// Resets
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("resets")]
        public DateTime Resets { get; set; }
    }
}