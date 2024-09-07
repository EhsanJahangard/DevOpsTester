using MediatR;
using Microsoft.AspNetCore.Mvc;
using TestApplication.CQRS.Master.Commands;
using TestApplication.CQRS.Master.Queries;
using TestApplication.DTOs.Common;

namespace TestEndPoint.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MasterController : ControllerBase
{

    private readonly IMediator _mediator;

    public MasterController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpPost("create")]
    public async Task<ActionResult<BaseResponseDto>> Create(CreateMasterCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
    [HttpPost("Master-getall")]
    public async Task<ActionResult<BaseResponseDto>> GetAll(GetAllMasterQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
}
