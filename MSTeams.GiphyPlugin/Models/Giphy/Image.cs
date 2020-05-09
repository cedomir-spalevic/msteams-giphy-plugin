using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MSTeams.GiphyPlugin.Models.Giphy
{
    public class Image
    {
        [JsonPropertyName("downsized_large")]
        public The480_WStill DownsizedLarge { get; set; }

        [JsonPropertyName("fixed_height_small_still")]
        public The480_WStill FixedHeightSmallStill { get; set; }

        [JsonPropertyName("original")]
        public FixedHeight Original { get; set; }

        [JsonPropertyName("fixed_height_downsampled")]
        public FixedHeight FixedHeightDownsampled { get; set; }

        [JsonPropertyName("downsized_still")]
        public The480_WStill DownsizedStill { get; set; }

        [JsonPropertyName("fixed_height_still")]
        public The480_WStill FixedHeightStill { get; set; }

        [JsonPropertyName("downsized_medium")]
        public The480_WStill DownsizedMedium { get; set; }

        [JsonPropertyName("downsized")]
        public The480_WStill Downsized { get; set; }

        [JsonPropertyName("preview_webp")]
        public The480_WStill PreviewWebp { get; set; }

        [JsonPropertyName("original_mp4")]
        public DownsizedSmall OriginalMp4 { get; set; }

        [JsonPropertyName("fixed_height_small")]
        public FixedHeight FixedHeightSmall { get; set; }

        [JsonPropertyName("fixed_height")]
        public FixedHeight FixedHeight { get; set; }

        [JsonPropertyName("downsized_small")]
        public DownsizedSmall DownsizedSmall { get; set; }

        [JsonPropertyName("preview")]
        public DownsizedSmall Preview { get; set; }

        [JsonPropertyName("fixed_width_downsampled")]
        public FixedHeight FixedWidthDownsampled { get; set; }

        [JsonPropertyName("fixed_width_small_still")]
        public The480_WStill FixedWidthSmallStill { get; set; }

        [JsonPropertyName("fixed_width_small")]
        public FixedHeight FixedWidthSmall { get; set; }

        [JsonPropertyName("original_still")]
        public The480_WStill OriginalStill { get; set; }

        [JsonPropertyName("fixed_width_still")]
        public The480_WStill FixedWidthStill { get; set; }

        [JsonPropertyName("looping")]
        public Looping Looping { get; set; }

        [JsonPropertyName("fixed_width")]
        public FixedHeight FixedWidth { get; set; }

        [JsonPropertyName("preview_gif")]
        public The480_WStill PreviewGif { get; set; }

        [JsonPropertyName("480w_still")]
        public The480_WStill The480WStill { get; set; }
    }
}
