using System;

namespace TestingDomainEvents.Domain.Models
{
    public class Persistence
    {
        protected Persistence()
        {

        }

        public Persistence(string playerId, string key, string value)
        {
            PlayerId = playerId;
            Key = key;
            Value = value;
        }

        public string PlayerId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
