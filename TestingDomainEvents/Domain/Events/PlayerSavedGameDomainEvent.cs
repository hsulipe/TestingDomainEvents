using System;
using TestingDomainEvents.Domain.Communication;

namespace TestingDomainEvents.Domain.Events
{
    public class PlayerSavedGameDomainEvent : DomainEvent
    {
        public string Key { get; private set; }
        public string Value { get; private set; }

        public PlayerSavedGameDomainEvent(string id, string key, string value) : base(id)
        {
            Key = key;
            Value = value;
        }
    }

    public class DeletePlayerDomainEvent : DomainEvent
    {
        public DeletePlayerDomainEvent(string id) : base(id)
        {
        }
    }
}
