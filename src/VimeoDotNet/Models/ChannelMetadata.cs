using System;
using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    [Serializable]
    public class ChannelMetadata
    {

        [PublicAPI]
        [JsonPropertyName("connections")]
        public ChannelConnections Connections { get; set; }

        [PublicAPI]
        [JsonPropertyName("interactions")]
        public ChannelInteractions Interactions { get; set; }
    }
}