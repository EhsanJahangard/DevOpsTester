using InfrastructureService;
using MediatR;

namespace AuthenticationApplication.Commands.RolePermission
{
    public class UpdateRolePermissionCommand : IRequest<ResponseMessage>
    {
        public string RoleId { get; set; }
        public List<string> PermissionIds { get; set; }
    }
}
