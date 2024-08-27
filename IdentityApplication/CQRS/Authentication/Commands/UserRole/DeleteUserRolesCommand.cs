using InfrastructureService;
using MediatR;

namespace IdentityApplication.CQRS.Authentication.Commands.UserRole;

public class DeleteUserRolesCommand : IRequest<ResponseMessage>
{
    public string UserId { get; set; }
}
