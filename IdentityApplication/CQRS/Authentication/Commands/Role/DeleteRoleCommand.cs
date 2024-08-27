using InfrastructureService;
using MediatR;

namespace IdentityApplication.CQRS.Authentication.Commands.Role;

public class DeleteRoleCommand : IRequest<ResponseMessage>
{
    public string Id { get; set; }
}
