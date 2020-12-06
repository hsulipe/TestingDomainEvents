using System.Threading.Tasks;

namespace TestingDomainEvents.Domain.Handler
{
    public interface IMediatrHandler
    {
        Task PublishDomainEvent<T>(T domainEvent);
    }
}
