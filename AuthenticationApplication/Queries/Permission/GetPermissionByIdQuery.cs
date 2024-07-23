using InfrastructureService;
using MediatR;

namespace AuthenticationApplication.Queries.Permission
{
    public class GetPermissionByIdQuery : IRequest<ResponseMessage>
    {
        public string Id { get; set; }
    }
}
