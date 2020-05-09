using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MSTeams.GiphyPlugin.Models.Giphy
{
    public class FixedHeight
    {
        [JsonPropertyName("height")]
        public string Height { get; set; }

        [JsonPropertyName("mp4")]
        public Uri Mp4 { get; set; }

        [JsonPropertyName("mp4_size")]
        public string Mp4Size { get; set; }

        [JsonPropertyName("size")]
        public string Size { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        [JsonPropertyName("webp")]
        public Uri Webp { get; set; }

        [JsonPropertyName("webp_size")]
        public string WebpSize { get; set; }

        [JsonPropertyName("width")]
        public string Width { get; set; }

        [JsonPropertyName("frames")]
        public string Frames { get; set; }

        [JsonPropertyName("hash")]
        public string Hash { get; set; }
    }
}
