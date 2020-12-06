using System;
using System.Threading.Tasks;
using TestingDomainEvents.Domain.Events;
using TestingDomainEvents.Domain.Handler;
using TestingDomainEvents.Domain.Models;

namespace TestingDomainEvents.Services
{
    public class PlayerPersistenceService : IPlayerPersistenceService
    {
        private readonly IMediatrHandler _mediatrHandler;

        public PlayerPersistenceService(IMediatrHandler mediatrHandler)
        {
            _mediatrHandler = mediatrHandler;
        }

        public async Task<bool> Save(string playerId, string key, string value)
        {
            var persistence = new Persistence(playerId, key, value);

            await _mediatrHandler.PublishDomainEvent(new PlayerSavedGameDomainEvent(playerId, key, value));
            return true;
        }
    }
}
