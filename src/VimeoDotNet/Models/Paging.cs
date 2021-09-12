using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    /// <summary>
    /// Paging
    /// </summary>
    public class Paging
    {
        /// <summary>
        /// Next
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("next")]
        public string Next { get; set; }

        /// <summary>
        /// Previous
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("previous")]
        public string Previous { get; set; }

        /// <summary>
        /// First
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("first")]
        public string First { get; set; }

        /// <summary>
        /// Last
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("last")]
        public string Last { get; set; }
    }
}