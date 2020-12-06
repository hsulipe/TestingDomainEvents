using System;
using System.Threading.Tasks;

namespace TestingDomainEvents.Services
{
    public interface IPlayerService
    {
        Task<DateTime> UpdateLastSaveGame(string playerId);
    }
}
