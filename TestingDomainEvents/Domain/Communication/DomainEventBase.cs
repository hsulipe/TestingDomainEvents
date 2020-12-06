using MediatR;
using System;

namespace TestingDomainEvents.Domain.Communication
{
    public abstract class DomainEventBase : DomainMessage, INotification
    {
        public DateTime Date { get; private set; }

        protected DomainEventBase(string id) : base(id)
        {
            Date = DateTime.UtcNow;
        }
    }
}
