using InfrastructureService;
using MediatR;

namespace AuthenticationApplication.Commands.UserRole
{
    public class AddUserRolesCommand : IRequest<ResponseMessage>
    {
        public string UserId { get; set; }
        public List<string> RoleIds { get; set; }
    }
}
