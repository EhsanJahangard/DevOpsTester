using InfrastructureService;
using MediatR;

namespace AuthenticationApplication.Commands.Role
{
    public class DeleteRoleCommand : IRequest<ResponseMessage>
    {
        public string Id { get; set; }
    }
}
