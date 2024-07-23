using AuthenticationApplication.Commands.RolePermission;
using AuthenticationApplication.Queries.RolePermission;
using AuthenticationService.Attributes;
using InfrastructureService;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolePermissionController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RolePermissionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Permission("GetPermissionsByRoleId")]
        [HttpPost("get")]
        public async Task<ResponseMessage> GetPermissionsByRoleIdAsync(GetPermissionByRoleIdQuery query)
        {
            return await _mediator.Send(query);
        }

        [Permission("AddRolePermissions")]
        [HttpPost("add")]
        public async Task<ResponseMessage> AddRolePermissionsAsync(AddRolePermissionCommand command)
        {
            return await _mediator.Send(command);
        }

        [Permission("UpdateRolePermissions")]
        [HttpPost("update")]
        public async Task<ResponseMessage> UpdateRolePermissionsAsync(UpdateRolePermissionCommand command)
        {
            return await _mediator.Send(command);
        }

        [Permission("DeleteRolePermissions")]
        [HttpPost("delete")]
        public async Task<ResponseMessage> DeleteRolePermissionsAsync(DeleteRolePermissionCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}
