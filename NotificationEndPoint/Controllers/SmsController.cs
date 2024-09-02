using InfrastructureService;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NotificationApplication.Commands;

namespace NotificationEndPoint.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SmsController : ControllerBase
{
    private readonly IMediator _mediator;

    public SmsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("Send")]
    public async Task<ResponseMessage> SendSmsAsync(SendSmsCommand command)
    {
        return await _mediator.Send(command);
    }
}
