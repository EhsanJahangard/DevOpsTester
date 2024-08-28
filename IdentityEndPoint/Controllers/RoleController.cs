using IdentityApplication.CQRS.Authentication.Commands.Role;
using IdentityApplication.CQRS.Authentication.Queries.Role;
using InfrastructureService;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using IdentityEndPoint.Attributes;
namespace IdentityEndPoint.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RoleController : ControllerBase
{
    private readonly IMediator _mediator;

    public RoleController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [Permission("GetAllRoles")]
    [HttpPost("get-all")]
    public async Task<ResponseMessage> GetAllRolesAsync(GetAllRoleQuery query)
    {
        return await _mediator.Send(query);
    }

    [Permission("GetRoleById")]
    [HttpPost("get")]
    public async Task<ResponseMessage> GetRoleByIdAsync(GetRoleByIdQuery query)
    {
        return await _mediator.Send(query);
    }

    [Permission("AddRole")]
    [HttpPost("add")]
    public async Task<ResponseMessage> AddRoleAsync(AddRoleCommand command)
    {
        command.Sender = User.Identity.Name;

        return await _mediator.Send(command);
    }

    [Permission("UpdateRole")]
    [HttpPost("update")]
    public async Task<ResponseMessage> UpdateRoleAsync(UpdateRoleCommand command)
    {
        command.Sender = User.Identity.Name;

        return await _mediator.Send(command);
    }

    [Permission("DeleteRole")]
    [HttpPost("delete")]
    public async Task<ResponseMessage> DeleteRoleAsync(DeleteRoleCommand command)
    {
        return await _mediator.Send(command);
    }
}