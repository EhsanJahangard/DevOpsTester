using IdentityApplication.CQRS.Authentication.Commands.User;
using IdentityApplication.CQRS.Authentication.Queries.User;
using InfrastructureService;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using IdentityEndPoint.Attributes;
namespace IdentityEndPoint.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IMediator _mediator;

    public UserController(IMediator mediator)
    {
        this._mediator = mediator;
    }

    [Permission("GetAllUsers")]
    [HttpPost("get-all")]
    public async Task<ResponseMessage> GetAllUsersAsync(GetAllUserQuery query)
    {
        return await _mediator.Send(query);
    }

    [Permission("GetUserById")]
    [HttpPost("get")]
    public async Task<ResponseMessage> GetUserByIdAsync(GetUserByIdQuery query)
    {
        return await _mediator.Send(query);
    }

    //[Permission("AddUser")]
    [HttpPost("add")]
    public async Task<ResponseMessage> AddUserAsync(AddUserCommand command)
    {
        command.Sender = string.IsNullOrEmpty(User.Identity.Name) ? command.Sender : User.Identity.Name;

        return await _mediator.Send(command);
    }

    [Permission("UpdateUser")]
    [HttpPost("update")]
    public async Task<ResponseMessage> UpdateUserAsync(UpdateUserCommand command)
    {
        command.Sender = User.Identity.Name;

        return await _mediator.Send(command);
    }

    [Permission("DeleteUser")]
    [HttpPost("delete")]
    public async Task<ResponseMessage> DeleteUserAsync(DeleteUserCommand command)
    {
        return await _mediator.Send(command);
    }
}