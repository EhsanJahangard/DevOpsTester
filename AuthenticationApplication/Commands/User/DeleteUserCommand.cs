using InfrastructureService;
using MediatR;

namespace AuthenticationApplication.Commands.User
{
    public class DeleteUserCommand : IRequest<ResponseMessage>
    {
        public string Id { get; set; }
    }
}
