using MediatR;
using Microsoft.AspNetCore.Mvc;
using TestApplication.CQRS.TestResult.Commands;
using TestApplication.CQRS.TestResult.Queries;
using TestApplication.DTOs.Common;

namespace TestEndPoint.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TestResultController : ControllerBase
{

    private readonly IMediator _mediator;

    public TestResultController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpPost("create")]
    public async Task<ActionResult<BaseResponseDto>> Create(CreateTestResultCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
    [HttpPost("TestResult-getall")]
    public async Task<ActionResult<BaseResponseDto>> GetAll(GetAllTestResultQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
}
