using System.Collections.Generic;
using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    /// <summary>
    /// Upload ticket
    /// </summary>
    public class UploadTicket
    {
        /// <summary>
        /// Ticket id
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("ticket_id")]
        public string TicketId { get; set; }

        /// <summary>
        /// URI
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Complete URI
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("complete_uri")]
        public string CompleteUri { get; set; }

        /// <summary>
        /// Upload URI
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("upload_uri")]
        public string UploadUri { get; set; }

        /// <summary>
        /// Upload URI secure
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("upload_uri_secure")]
        public string UploadUriSecure { get; set; }

        /// <summary>
        /// Upload link
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("upload_link")]
        public string UploadLink { get; set; }

        /// <summary>
        /// Upload link secure
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("upload_link_secure")]
        public string UploadLinkSecure { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// User
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("user")]
        public User User { get; set; }

        /// <summary>
        /// Video
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("video")]
        public Video Video { get; set; }

        /// <summary>
        /// Upload status
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("upload")]
        public UploadStatus Upload { get; set; }

        /// <summary>
        /// Transcode
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("transcode")]
        public List<Transcode> Transcode { get; set; }

        /// <summary>
        /// Quota
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("quota")]
        public UploadTicketQuota Quota { get; set; }
    }
}