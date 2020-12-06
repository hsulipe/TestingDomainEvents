using MediatR;
using System.Threading.Tasks;

namespace TestingDomainEvents.Domain.Handler
{
    public class MediatrHandler : IMediatrHandler
    {
        private readonly IMediator _mediator;

        public MediatrHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task PublishDomainEvent<T>(T domainEvent)
        {
            await _mediator.Publish(domainEvent);
        }
    }
}
