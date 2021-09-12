using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    public class ChannelFollowEntry
    {
       
        [PublicAPI]
        [JsonPropertyName("added")]
        public bool Added { get; set; }

        [PublicAPI]
        [JsonPropertyName("added_time")]
        public DateTime? AddedTime { get; set; }

        [PublicAPI]
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [PublicAPI]
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
    }
}