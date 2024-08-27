using InfrastructureService;
using MediatR;

namespace IdentityApplication.CQRS.Authentication.Commands.Permission;

public class DeletePermissionCommand : IRequest<ResponseMessage>
{
    public string Id { get; set; }
}
