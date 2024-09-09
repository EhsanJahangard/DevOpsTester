using MediatR;
using Microsoft.AspNetCore.Mvc;
using TestApplication.CQRS.PersonSkill.Commands;
using TestApplication.CQRS.PersonSkill.Queries;
using TestApplication.DTOs.Common;

namespace TestEndPoint.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PersonSkillController : ControllerBase
{

    private readonly IMediator _mediator;

    public PersonSkillController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpPost("create")]
    public async Task<ActionResult<BaseResponseDto>> Create(CreatePersonSkillCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
    [HttpPost("PersonSkill-getall")]
    public async Task<ActionResult<BaseResponseDto>> GetAll(GetAllPersonSkillQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
}
