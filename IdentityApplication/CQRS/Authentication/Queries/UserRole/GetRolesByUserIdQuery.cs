using InfrastructureService;
using MediatR;

namespace IdentityApplication.CQRS.Authentication.Queries.UserRole;

public class GetRolesByUserIdQuery : IRequest<ResponseMessage>
{
    public string UserId { get; set; }
}
