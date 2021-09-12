using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    /// <summary>
    /// User quota
    /// </summary>
    public class UserQuota
    {
        /// <summary>
        /// HD
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("hd")]
        public bool Hd { get; set; }

        /// <summary>
        /// SD
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("sd")]
        public bool Sd { get; set; }
    }
}