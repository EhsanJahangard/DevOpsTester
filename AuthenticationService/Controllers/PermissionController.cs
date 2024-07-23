using AuthenticationApplication.Commands.Permission;
using AuthenticationApplication.Queries.Permission;
using AuthenticationService.Attributes;
using InfrastructureService;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PermissionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Permission("GetAllPermissions")]
        [HttpPost("get-all")]
        public async Task<ResponseMessage> GetAllPermissionsAsync(GetAllPermissionQuery query)
        {
            return await _mediator.Send(query);
        }

        [Permission("GetPermissionById")]
        [HttpPost("get")]
        public async Task<ResponseMessage> GetPermissionByIdAsync(GetPermissionByIdQuery query)
        {
            return await _mediator.Send(query);
        }

        [Permission("AddPermission")]
        [HttpPost("add")]
        public async Task<ResponseMessage> AddPermissionAsync(AddPermissionCommand command)
        {
            command.Sender = User.Identity.Name;

            return await _mediator.Send(command);
        }

        [Permission("UpdatePermission")]
        [HttpPost("update")]
        public async Task<ResponseMessage> UpdatePermissionAsync(UpdatePermissionCommand command)
        {
            command.Sender = User.Identity.Name;

            return await _mediator.Send(command);
        }

        [Permission("DeletePermission")]
        [HttpPost("delete")]
        public async Task<ResponseMessage> DeletePermissionAsync(DeletePermissionCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}
