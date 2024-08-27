using InfrastructureService;
using MediatR;

namespace IdentityApplication.CQRS.Authentication.Commands.Role;

public class AddRoleCommand : IRequest<ResponseMessage>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string? Sender { get; set; }
}
