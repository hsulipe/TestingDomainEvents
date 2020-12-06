using MediatR;

namespace TestingDomainEvents.Domain.Communication
{
    public class DomainEvent : DomainEventBase, INotification
    {
        public DomainEvent(string id) : base(id)
        {
            AggregateId = id;
        }
    }
}
