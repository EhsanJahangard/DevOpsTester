using InfrastructureService;
using MediatR;

namespace AuthenticationApplication.Commands.UserRole
{
    public class DeleteUserRolesCommand : IRequest<ResponseMessage>
    {
        public string UserId { get; set; }
    }
}
