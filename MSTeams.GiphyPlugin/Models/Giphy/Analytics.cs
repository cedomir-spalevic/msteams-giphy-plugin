using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MSTeams.GiphyPlugin.Models.Giphy
{
    public class Analytics
    {
        [JsonPropertyName("onload")]
        public AnalyticsUri OnLoad { get; set; }

        [JsonPropertyName("onclick")]
        public AnalyticsUri OnClick { get; set; }

        [JsonPropertyName("onsent")]
        public AnalyticsUri OnSent { get; set; }
    }
}
