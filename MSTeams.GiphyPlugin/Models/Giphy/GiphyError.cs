using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MSTeams.GiphyPlugin.Models.Giphy
{
    public class GiphyError
    {
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
