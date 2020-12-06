using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestingDomainEvents.Domain.Models;

namespace TestingDomainEvents.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly List<Player> _repository;

        public PlayerService()
        {
            _repository = new List<Player>() { new Player(Guid.Parse("74189543-a47f-4356-a40f-31c8ff8fa62f"), DateTime.Now.AddDays(-1)) };
        }

        public async Task<DateTime> UpdateLastSaveGame(string playerId)
        {
            var entity = _repository.Find(x => x.PlayerId == Guid.Parse(playerId));
            entity.LastSaveUpdate();
            System.Diagnostics.Debug.WriteLine($"Updated Player: {playerId}, Last Save Game");
            return entity.LastSaveGame;
        }
    }
}
