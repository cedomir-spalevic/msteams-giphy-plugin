using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MSTeams.GiphyPlugin.Models.Giphy
{
    public class Looping
    {
        [JsonPropertyName("mp4")]
        public Uri Mp4 { get; set; }

        [JsonPropertyName("mp4_size")]
        public string Mp4Size { get; set; }
    }
}
