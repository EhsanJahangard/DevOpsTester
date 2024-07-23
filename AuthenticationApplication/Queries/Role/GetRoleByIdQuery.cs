using InfrastructureService;
using MediatR;

namespace AuthenticationApplication.Queries.Role
{
    public class GetRoleByIdQuery : IRequest<ResponseMessage>
    {
        public string Id { get; set; } 
    }
}
