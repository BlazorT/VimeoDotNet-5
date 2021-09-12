using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    /// <summary>
    /// Space
    /// </summary>
    public class Space
    {
        /// <summary>
        /// Max
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("max")]
        public long Max { get; set; }

        /// <summary>
        /// Free
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("free")]
        public long Free { get; set; }

        /// <summary>
        /// Used
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("used")]
        public long Used { get; set; }
    }
}