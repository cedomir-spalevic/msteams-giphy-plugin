using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MSTeams.GiphyPlugin.Models.Giphy
{
    public class GiphyResponse
    {
        [JsonPropertyName("data")]
        public List<Gif> Data { get; set; }

        [JsonPropertyName("pagination")]
        public Pagination Pagination { get; set; } 

        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }
    }
}
