using System.Collections.Generic;
using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    /// <summary>
    /// Upload ticket
    /// </summary>
    public class TusResumableUploadTicket : Video
    {
        
        /// <summary>
        /// Upload status
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("upload")]
        public ResumableUploadStatus Upload { get; set; }
    }

    public class ResumableUploadStatus
    {
        /// <summary>
        /// Upload Approach
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("approach")]
        public string Approach { get; set; }

        /// <summary>
        /// Upload Status
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("status")]
        public string Status { get; set; }


        /// <summary>
        /// Upload link
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("upload_link")]
        public string UploadLink { get; set; }

        /// <summary>
        /// Video Size in bytes
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("size")]
        public long Size { get; set; }

    }
}
