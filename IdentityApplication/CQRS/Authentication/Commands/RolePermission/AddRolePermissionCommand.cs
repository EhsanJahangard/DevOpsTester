using InfrastructureService;
using MediatR;

namespace IdentityApplication.CQRS.Authentication.Commands.RolePermission;

public class AddRolePermissionCommand : IRequest<ResponseMessage>
{
    public string RoleId { get; set; }
    public List<string> PermissionIds { get; set; }
}
