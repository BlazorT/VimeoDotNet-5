using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    /// <summary>
    /// User upload quota
    /// </summary>
    public class UserUploadQuota
    {
        /// <summary>
        /// Space
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("space")]
        public Space Space { get; set; }

        /// <summary>
        /// Resets
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("resets")]
        public int Resets { get; set; }

        /// <summary>
        /// Quota
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("quota")]
        public UserQuota Quota { get; set; }
    }
}