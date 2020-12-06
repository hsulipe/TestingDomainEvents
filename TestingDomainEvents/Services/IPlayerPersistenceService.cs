using System.Threading.Tasks;

namespace TestingDomainEvents.Services
{
    public interface IPlayerPersistenceService
    {
        Task<bool> Save(string playerId, string key, string value);
    }
}
