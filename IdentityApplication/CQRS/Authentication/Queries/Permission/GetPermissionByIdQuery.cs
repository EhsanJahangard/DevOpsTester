using InfrastructureService;
using MediatR;

namespace IdentityApplication.CQRS.Authentication.Queries.Permission;

public class GetPermissionByIdQuery : IRequest<ResponseMessage>
{
    public string Id { get; set; }
}
