using MediatR;
using Microsoft.AspNetCore.Mvc;
using TestApplication.CQRS.Photo.Commands;
using TestApplication.CQRS.Photo.Queries;
using TestApplication.DTOs.Common;

namespace TestEndPoint.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PhotoController : ControllerBase
{

    private readonly IMediator _mediator;

    public PhotoController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpPost("create")]
    public async Task<ActionResult<BaseResponseDto>> Create(CreatePhotoCommand request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
    [HttpPost("photo-getall")]
    public async Task<ActionResult<BaseResponseDto>> GetAll(GetAllPhotoQuery request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
}
