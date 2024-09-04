using MediatR;
using Microsoft.AspNetCore.Mvc;
using TestApplication.CQRS.Question.Commands;
using TestApplication.CQRS.Question.Queries;
using TestApplication.DTOs.Common;

namespace TestEndPoint.Controllers;

[Route("api/[controller]")]
[ApiController]
public class QuestionController : ControllerBase
{

    private readonly IMediator _mediator;

    public QuestionController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpPost("create")]
    public async Task<ActionResult<BaseResponseDto>> Create(CreateQuestionCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
    [HttpPost("Question-getall")]
    public async Task<ActionResult<BaseResponseDto>> GetAll(GetAllQuestionQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
}