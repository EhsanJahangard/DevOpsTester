using InfrastructureService;
using MediatR;

namespace IdentityApplication.CQRS.Authentication.Queries.RolePermission;

public class GetPermissionByRoleIdQuery : IRequest<ResponseMessage>
{
    public string RoleId { get; set; }
}
