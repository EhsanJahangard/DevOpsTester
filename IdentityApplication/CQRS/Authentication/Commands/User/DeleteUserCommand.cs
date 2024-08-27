using InfrastructureService;
using MediatR;

namespace IdentityApplication.CQRS.Authentication.Commands.User;

public class DeleteUserCommand : IRequest<ResponseMessage>
{
    public string Id { get; set; }
}
