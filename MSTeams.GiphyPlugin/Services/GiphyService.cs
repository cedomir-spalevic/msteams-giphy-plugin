using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using MSTeams.GiphyPlugin.Models.Config;
using MSTeams.GiphyPlugin.Models.Giphy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace MSTeams.GiphyPlugin.Services
{
    public class GiphyService
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly GiphyOptions _options;

        public GiphyService(IOptions<GiphyOptions> options, IHttpClientFactory clientFactory)
        {
            this._options = options.Value;
            this._clientFactory = clientFactory;
        }

        public async Task<GiphyResponse> GetTrending(int offset = 0)
        {
            string url = $"{this._options.ApiUrl}gifs/trending?api_key={this._options.ApiKey}&limit=20&offset={offset}";
            return await this.CallAPI(url);
        }

        public async Task<GiphyResponse> Search(string query, int offset = 0)
        {
            string url = $"{this._options.ApiUrl}gifs/search?api_key={this._options.ApiKey}&q={query}&limit=20&offset={offset}";
            return await this.CallAPI(url);
        }

        private async Task<GiphyResponse> CallAPI(string url)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            var client = this._clientFactory.CreateClient();
            var response = await client.SendAsync(request);
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                var error = JsonSerializer.Deserialize<GiphyError>(content);
                throw new GiphyErrorResponse() { GiphyError = error };
            }
            return JsonSerializer.Deserialize<GiphyResponse>(content);
        }
    }
}
