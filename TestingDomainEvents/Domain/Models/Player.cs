using System;

namespace TestingDomainEvents.Domain.Models
{
    public class Player : IAggregateRoot
    {
        public Player()
        {
            
        }
        public Player(Guid playerId, DateTime lastSaveGame)
        {
            PlayerId = playerId;
            LastSaveGame = lastSaveGame;
        }
        public Guid PlayerId { get; private set; }
        public DateTime LastSaveGame { get; private set; }

        public void LastSaveUpdate()
        {
            this.LastSaveGame = DateTime.UtcNow;
        }
    }
}
