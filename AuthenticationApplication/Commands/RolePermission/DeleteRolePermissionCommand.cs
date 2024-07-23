using InfrastructureService;
using MediatR;

namespace AuthenticationApplication.Commands.RolePermission
{
    public class DeleteRolePermissionCommand : IRequest<ResponseMessage>
    {
        public string RoleId { get; set; }  
    }
}
