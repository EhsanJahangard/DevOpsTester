using MediatR;
using Microsoft.AspNetCore.Mvc;
using TestApplication.CQRS.TestQuestion.Commands;
using TestApplication.CQRS.TestQuestion.Queries;
using TestApplication.DTOs.Common;

namespace TestEndPoint.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TestQuestionController : ControllerBase
{

    private readonly IMediator _mediator;

    public TestQuestionController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpPost("create")]
    public async Task<ActionResult<BaseResponseDto>> Create(CreateTestQuestionCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
    [HttpPost("TestQuestion-getall")]
    public async Task<ActionResult<BaseResponseDto>> GetAll(GetAllTestQuestionQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
}