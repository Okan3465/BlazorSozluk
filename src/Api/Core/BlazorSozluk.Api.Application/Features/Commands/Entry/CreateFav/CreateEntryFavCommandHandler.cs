using BlazorSozluk.Api.Application.Features.Commands.EntryComment.CreateFav;
using BlazorSozluk.Common.Events.EntryComment;
using BlazorSozluk.Common.Infrastructure;
using BlazorSozluk.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorSozluk.Common.Events.Entry;

namespace BlazorSozluk.Api.Application.Features.Commands.Entry.CreateFav
{
    public class CreateEntryFavCommandHandler : IRequestHandler<CreateEntryFavCommand, bool>
    {
        public async Task<bool> Handle(CreateEntryFavCommand request, CancellationToken cancellationToken)
        {
            QueueFactory.SendMessageToExchange(
                exchangeName: SozlukConstants.FavExchangeName,
                exchangeType: SozlukConstants.DefaultExchangeType,
                queueName: SozlukConstants.CreateEntryFavQueueName,
                obj: new CreateEntryFavEvent()
                {
                    CreatedBy = request.UserId.Value,
                    EntryId = request.EntryId.Value
                });

            return await Task.FromResult(true);
        }
    }
}
