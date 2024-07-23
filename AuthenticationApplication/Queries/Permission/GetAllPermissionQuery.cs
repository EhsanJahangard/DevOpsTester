using InfrastructureService;
using MediatR;

namespace AuthenticationApplication.Queries.Permission
{
    public class GetAllPermissionQuery : IRequest<ResponseMessage>
    {
    }
}
