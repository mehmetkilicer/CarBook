using CarBook.Application.Features.Mediator.Commands.LogoutCommands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CarBook.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogoutController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LogoutController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Logout([FromBody] string token)
        {
            var command = new LogoutCommand(token);
            await _mediator.Send(command);
            return Ok("Logout successful");
        }
    }
}
