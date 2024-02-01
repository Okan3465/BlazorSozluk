﻿using BlazorSozluk.Common.Infrastructure;
using BlazorSozluk.Common.Models.RequestModels;
using BlazorSozluk.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorSozluk.Common.Events.Entry;

namespace BlazorSozluk.Api.Application.Features.Commands.EntryComment.CreateVote
{
    public class CreateEntryCommentVoteCommandHandle : IRequestHandler<CreateEntryCommentVoteCommand, bool>
    {
        public async Task<bool> Handle(CreateEntryCommentVoteCommand request, CancellationToken cancellationToken)
        {
            QueueFactory.SendMessageToExchange(
                exchangeName: SozlukConstants.VoteExchangeName,
                exchangeType: SozlukConstants.DefaultExchangeType,
                queueName: SozlukConstants.CreateEntryCommentVoteQueueName,
                obj: new CreateEntryCommentVoteEvent()
                {
                    EntryCommentId = request.EntryCommentId,
                    VoteType = request.VoteType,
                    CreatedBy = request.CreatedBy,
                });

            return await Task.FromResult(true);
        }
    }
}
