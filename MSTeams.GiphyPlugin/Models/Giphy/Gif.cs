using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MSTeams.GiphyPlugin.Models.Giphy
{
    public class Gif
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        [JsonPropertyName("bitly_gif_url")]
        public Uri BitlyGifUrl { get; set; }

        [JsonPropertyName("bitly_url")]
        public Uri BitlyUrl { get; set; }

        [JsonPropertyName("embed_url")]
        public Uri EmbedUrl { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("rating")]
        public string Rating { get; set; }

        [JsonPropertyName("content_url")]
        public string ContentUrl { get; set; }

        [JsonPropertyName("source_tld")]
        public string SourceTld { get; set; }

        [JsonPropertyName("source_post_url")]
        public string SourcePostUrl { get; set; }

        [JsonPropertyName("is_sticker")]
        public long IsSticker { get; set; }

        [JsonPropertyName("import_datetime")]
        public string ImportDatetime { get; set; }

        [JsonPropertyName("trending_datetime")]
        public string TrendingDatetime { get; set; }

        [JsonPropertyName("images")]
        public Image Images { get; set; }

        [JsonPropertyName("user")]
        public User User { get; set; }

        [JsonPropertyName("analytics_response_payload")]
        public string AnalyticsResponsePayload { get; set; }

        [JsonPropertyName("analytics")]
        public Analytics Analytics { get; set; }
    }
}
