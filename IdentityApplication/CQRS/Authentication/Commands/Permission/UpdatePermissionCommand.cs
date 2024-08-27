using InfrastructureService;
using MediatR;

namespace IdentityApplication.CQRS.Authentication.Commands.Permission;

public class UpdatePermissionCommand : IRequest<ResponseMessage>
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ServiceType { get; set; }
    public string? Sender { get; set; }
}
