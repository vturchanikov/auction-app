using Contracts;
using Mapster;
using Meilisearch;
using SearchService.Models;

namespace SearchService.Handlers;

public class AuctionCreatedHandler
{
    public async Task Handle(AuctionCreated message, MeilisearchClient client)
    {
        var item = message.Adapt<Item>();
        await client.Index("items").AddDocumentsAsync([item]);
    }
}