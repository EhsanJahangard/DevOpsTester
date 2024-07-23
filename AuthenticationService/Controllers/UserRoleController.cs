﻿using AuthenticationApplication.Commands.UserRole;
using AuthenticationApplication.Queries.UserRole;
using AuthenticationService.Attributes;
using InfrastructureService;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRoleController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserRoleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Permission("GetRolesByUserId")]
        [HttpPost("get")]
        public async Task<ResponseMessage> GetRolesByUserIdAsync(GetRolesByUserIdQuery query)
        {
            return await _mediator.Send(query);
        }

        [Permission("AddUserRoles")]
        [HttpPost("add")]
        public async Task<ResponseMessage> AddUserRolesAsync(AddUserRolesCommand command)
        {
            return await _mediator.Send(command);
        }

        [Permission("UpdateUserRoles")]
        [HttpPost("update")]
        public async Task<ResponseMessage> UpdateUserRolesAsync(UpdateUserRolesCommand command)
        {
            return await _mediator.Send(command);
        }

        [Permission("DeleteUserRoles")]
        [HttpPost("delete")]
        public async Task<ResponseMessage> DeleteUserRolesAsync(DeleteUserRolesCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}
