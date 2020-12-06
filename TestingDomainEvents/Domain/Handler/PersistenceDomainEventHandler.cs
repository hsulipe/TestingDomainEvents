using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TestingDomainEvents.Domain.Events;
using TestingDomainEvents.Services;

namespace TestingDomainEvents.Domain.Handler
{
    public class PersistenceDomainEventHandler : INotificationHandler<PlayerSavedGameDomainEvent>
    {
        private readonly IPlayerService _playerService;

        public PersistenceDomainEventHandler(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        public async Task Handle(PlayerSavedGameDomainEvent notification, CancellationToken cancellationToken)
        {
            await _playerService.UpdateLastSaveGame(notification.AggregateId);
        }
    }
}
