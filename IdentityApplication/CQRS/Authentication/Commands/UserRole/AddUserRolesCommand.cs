using InfrastructureService;
using MediatR;

namespace IdentityApplication.CQRS.Authentication.Commands.UserRole;

public class AddUserRolesCommand : IRequest<ResponseMessage>
{
    public string UserId { get; set; }
    public List<string> RoleIds { get; set; }
}
