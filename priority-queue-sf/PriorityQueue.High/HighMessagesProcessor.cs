﻿using System.Fabric;
using System.Threading.Tasks;
using PriorityQueue.Shared;
using Microsoft.ServiceBus.Messaging;
using System.Diagnostics;

namespace PriorityQueue.High
{
    /// <summary>
    /// An instance of this class is created for each service instance by the Service Fabric runtime.
    /// </summary>
    internal sealed class HighMessagesProcessor : PriorityStatelessService
    {
        public HighMessagesProcessor(StatelessServiceContext context)
            : base(context)
        { }

        protected override async Task ProcessMessageAsync(BrokeredMessage message)
        {
            // simulate message processing for High priority messages
            await base.ProcessMessageAsync(message)
                .ConfigureAwait(false);
            Trace.TraceInformation($"High priority message processed by {this.Context.NodeContext.NodeId} MessageId: {message.MessageId}");
        }
    }
}
