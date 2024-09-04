﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using TestApplication.CQRS.Level.Commands;
using TestApplication.CQRS.Level.Queries;
using TestApplication.DTOs.Common;
namespace TestEndPoint.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LevelController : ControllerBase
{
    private readonly IMediator _mediator;

    public LevelController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpPost("create")]
    public async Task<ActionResult<BaseResponseDto>> Create( CreateLevelCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
    [HttpPost("level-getall")]
    public async Task<ActionResult<BaseResponseDto>> GetAll(GetAllLevelQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

}
