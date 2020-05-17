using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;
using Microsoft.Bot.Builder.Teams;
using Microsoft.Bot.Schema.Teams;
using Newtonsoft.Json.Linq;
using System.Linq;
using System;
using System.Collections.Generic;
using Bogus;
using MSTeams.GiphyPlugin.Services;
using MSTeams.GiphyPlugin.Models.Giphy;

namespace MSTeams.GiphyPlugin.Bots
{
    public class MessageExtension : TeamsActivityHandler
    {
        private readonly GiphyService _giphyService;

        public MessageExtension(GiphyService giphyService)
        {
            this._giphyService = giphyService;
        }

        //protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        //{
        //    turnContext.Activity.RemoveRecipientMention();
        //    var text = turnContext.Activity.Text.Trim().ToLower();

        //    var replyText = $"You said: {text}";
        //    await turnContext.SendActivityAsync(MessageFactory.Text(replyText, replyText), cancellationToken);
        //}

        protected override async Task<MessagingExtensionResponse> OnTeamsMessagingExtensionQueryAsync(ITurnContext<IInvokeActivity> turnContext, MessagingExtensionQuery query, CancellationToken cancellationToken)
        {
            var tempSearch = "";
            var searchParam = query.Parameters?.FirstOrDefault(p => p.Name == "query");
            if (searchParam != null)
            {
                tempSearch = searchParam.Value.ToString();
            }

            if (query == null || query.CommandId != "searchGifs")
            {
                throw new NotImplementedException($"Invalid CommandId: {query.CommandId}");
            }

            // Parse tempSearch for the page number
            var pageNo = 0;
            var temp = tempSearch.Split(":");
            if (temp.Length > 1 && !Int32.TryParse(temp[1], out pageNo))
                pageNo = 0;

            // If the search term is blank - search trending
            GiphyResponse giphyResponse = null;
            if (string.IsNullOrEmpty(temp[0]))
                giphyResponse = await this._giphyService.GetTrending(pageNo);
            else
                giphyResponse = await this._giphyService.Search(temp[0], pageNo);

            // Create Message Extension Response
            var gifs = new List<MessagingExtensionAttachment>();
            foreach (var gif in giphyResponse.Data)
            {
                var card = new HeroCard();
                card.Images = new List<CardImage> { new CardImage(gif.Images.DownsizedLarge.Url.ToString()) };
                gifs.Add(card.ToAttachment().ToMessagingExtensionAttachment());
            }

            var result = new MessagingExtensionResponse
            {
                ComposeExtension = new MessagingExtensionResult
                {
                    AttachmentLayout = "grid",
                    Type = "result",
                    Attachments = gifs.ToList()
                },
            };
            return result;

        }

        protected override Task<MessagingExtensionResponse> OnTeamsMessagingExtensionSelectItemAsync(ITurnContext<IInvokeActivity> turnContext, JObject query, CancellationToken cancellationToken)
        {
            return Task.FromResult(new MessagingExtensionResponse
            {
                ComposeExtension = new MessagingExtensionResult
                {
                    AttachmentLayout = "list",
                    Type = "result",
                    Attachments = new MessagingExtensionAttachment[]{
                        new HeroCard()
                            .ToAttachment()
                            .ToMessagingExtensionAttachment()
                    }
                },
            });
        }
    }
}
