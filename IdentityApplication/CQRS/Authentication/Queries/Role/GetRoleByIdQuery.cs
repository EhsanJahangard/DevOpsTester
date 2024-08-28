using InfrastructureService;
using MediatR;

namespace IdentityApplication.CQRS.Authentication.Queries.Role;

public class GetRoleByIdQuery : IRequest<ResponseMessage>
{
    public string Id { get; set; }
}
