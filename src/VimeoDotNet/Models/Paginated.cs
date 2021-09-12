using System.Collections.Generic;
using JetBrains.Annotations;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace VimeoDotNet.Models
{
    /// <summary>
    /// Paginated
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Paginated<T> where T : class
    {
        /// <summary>
        /// Content
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("data")]
        public List<T> Data { get; set; }

        /// <summary>
        /// Total
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("total")]
        public int Total { get; set; }

        /// <summary>
        /// Page
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("page")]
        public int Page { get; set; }

        /// <summary>
        /// Per page
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("per_page")]
        public int PerPage { get; set; }

        /// <summary>
        /// Paging
        /// </summary>
        [PublicAPI]
        [JsonPropertyName("paging")]
        public Paging Paging { get; set; }
    }
}