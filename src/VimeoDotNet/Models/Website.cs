using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    /// <summary>
    /// Web site
    /// </summary>
    public class Website
    {
        /// <summary>
        /// Name
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Link
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("link")]
        public string Link { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}