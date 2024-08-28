using IdentityApplication.CQRS.Authentication.Commands.Login;
using InfrastructureService;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace IdentityEndPoint.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LoginController : ControllerBase
{
    private readonly IMediator _mediator;

    public LoginController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("send-code")]
    public async Task<ResponseMessage> Login(SendVerificationCodeCommand command)
    {
        return await _mediator.Send(command);
    }

    [HttpPost("check-code")]
    public async Task<ResponseMessage> Login(CheckVerificationCodeCommand command)
    {
        return await _mediator.Send(command);
    }
}
