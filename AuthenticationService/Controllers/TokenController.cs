using AuthenticationApplication.Commands.Token;
using InfrastructureService;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AuthenticationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TokenController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("refresh")]
        public async Task<ResponseMessage> GenerateRefreshTokenAsync(GenereateRefreshTokenCommand command)
        {
            ResponseMessage responseMessage = await _mediator.Send(command);

            if (responseMessage.Status == HttpStatusCode.Unauthorized)
                 Response.StatusCode = (int) HttpStatusCode.Unauthorized;
            
            return responseMessage;
        }
    }
}
