using InfrastructureService;
using MediatR;

namespace AuthenticationApplication.Queries.RolePermission
{
    public class GetPermissionByRoleIdQuery : IRequest<ResponseMessage>
    {
        public string RoleId { get; set; }  
    }
}
