using MediatR;
using Microsoft.AspNetCore.Mvc;
using TestApplication.CQRS.QuestionType.Commands;
using TestApplication.CQRS.QuestionType.Queries;
using TestApplication.DTOs.Common;

namespace TestEndPoint.Controllers;

[Route("api/[controller]")]
[ApiController]
public class QuestionTypeController : ControllerBase
{

    private readonly IMediator _mediator;

    public QuestionTypeController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpPost("create")]
    public async Task<ActionResult<BaseResponseDto>> Create(CreateQuestionTypeCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
    [HttpPost("QuestionType-getall")]
    public async Task<ActionResult<BaseResponseDto>> GetAll(GetAllQuestionTypeQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
}

