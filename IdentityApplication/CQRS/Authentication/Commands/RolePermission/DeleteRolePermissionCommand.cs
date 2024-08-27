using InfrastructureService;
using MediatR;

namespace IdentityApplication.CQRS.Authentication.Commands.RolePermission;

public class DeleteRolePermissionCommand : IRequest<ResponseMessage>
{
    public string RoleId { get; set; }
}
