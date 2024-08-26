using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApplication.CQRS.Level.Commands;
using TestApplication.DTOs.Common;
namespace TestEndPoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LevelController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LevelController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //[HttpGet]
        //public async Task<ActionResult<List<GetAllUserResponse>>> GetAll(CancellationToken cancellationToken)
        //{
        //    var response = await _mediator.Send(new GetAllUserRequest(), cancellationToken);
        //    return Ok(response);
        //}

        [HttpPost("create")]
        public async Task<ActionResult<BaseResponseDto>> Create( CreateLevelCommand request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

    }
}
