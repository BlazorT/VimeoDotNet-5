using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    public class ChannelInteractions
    {
        [PublicAPI]
        [JsonPropertyName("add_moderators")]
        public ChannelInteractionsEntry AddModerators { get; set; }

        [PublicAPI]
        [JsonPropertyName("moderate_videos")]
        public ChannelInteractionsEntry ModerateVideos { get; set; }

        [PublicAPI]
        [JsonPropertyName("follow")]
        public ChannelFollowEntry Follow { get; set; }
    }
}