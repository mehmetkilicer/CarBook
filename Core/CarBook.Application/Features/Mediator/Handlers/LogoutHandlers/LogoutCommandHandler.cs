using CarBook.Application.Features.Mediator.Commands.LogoutCommands;
using CarBook.Application.interfaces.LogoutInterfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.LogoutHandlers
{
    public class LogoutCommandHandler : IRequestHandler<LogoutCommand>
    {
        private readonly ILogoutRepository _logoutRepository;

        public LogoutCommandHandler(ILogoutRepository logoutRepository)
        {
            _logoutRepository = logoutRepository;
        }

        public Task Handle(LogoutCommand request, CancellationToken cancellationToken)
        {
            // Token'i geçersiz kıl
            _logoutRepository.InvalidateToken(request.Token);

            // Task dönüşü sağlanır, Unit.Value yerine sadece Task kullanılıyor
            return Task.CompletedTask;
        }
    }
}
