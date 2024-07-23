using AuthenticationApplication.Commands.Password;
using AuthenticationService.Attributes;
using InfrastructureService;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PasswordController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PasswordController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Permission("ChangePassword")]
        [HttpPost("change")]
        public async Task<ResponseMessage> ChangePasswordAsync(ChangePasswordCommand command)
        {
            command.Sender = User.Identity.Name;

            return await _mediator.Send(command);
        }

        [Permission("ResetPassword")]
        [HttpPost("reset")]
        public async Task<ResponseMessage> ResetPasswordAsync(ResetPasswordCommand command)
        {
            command.Sender = User.Identity.Name;

            return await _mediator.Send(command);
        }
    }
}
