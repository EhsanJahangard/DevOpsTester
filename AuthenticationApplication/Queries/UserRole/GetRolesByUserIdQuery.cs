using InfrastructureService;
using MediatR;

namespace AuthenticationApplication.Queries.UserRole
{
    public class GetRolesByUserIdQuery : IRequest<ResponseMessage>
    {
        public string UserId { get; set; }  
    }
}
