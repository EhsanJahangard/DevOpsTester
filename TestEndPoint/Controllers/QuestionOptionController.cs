using MediatR;
using Microsoft.AspNetCore.Mvc;
using TestApplication.CQRS.QuestionOption.Commands;
using TestApplication.CQRS.QuestionOption.Queries;
using TestApplication.DTOs.Common;

namespace TestEndPoint.Controllers;

[Route("api/[controller]")]
[ApiController]
public class QuestionOptionController : ControllerBase
{

    private readonly IMediator _mediator;

    public QuestionOptionController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpPost("create")]
    public async Task<ActionResult<BaseResponseDto>> Create(CreateQuestionOptionCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
    [HttpPost("QuestionOption-getall")]
    public async Task<ActionResult<BaseResponseDto>> GetAll(GetAllQuestionOptionQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
}
