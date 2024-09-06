using MediatR;
using Microsoft.AspNetCore.Mvc;
using TestApplication.CQRS.Skill.Commands;
using TestApplication.CQRS.Skill.Queries;
using TestApplication.DTOs.Common;

namespace TestEndPoint.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SkillController : ControllerBase
{

    private readonly IMediator _mediator;

    public SkillController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpPost("create")]
    public async Task<ActionResult<BaseResponseDto>> Create(CreateSkillCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
    [HttpPost("Skill-getall")]
    public async Task<ActionResult<BaseResponseDto>> GetAll(GetAllSkillQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
}