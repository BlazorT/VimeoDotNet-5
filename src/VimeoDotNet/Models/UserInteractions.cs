using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    /// <summary>
    /// User interactions
    /// </summary>
    public class UserInteractions
    {
        /// <summary>
        /// Follow
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("follow")]
        public Follow Follow { get; set; }
    }
}