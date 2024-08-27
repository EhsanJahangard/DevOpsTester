using InfrastructureService;
using MediatR;

namespace IdentityApplication.CQRS.Authentication.Commands.Login;

public class SendVerificationCodeCommand : IRequest<ResponseMessage>
{
    public string Username { get; set; }
    public string Password { get; set; }
}
