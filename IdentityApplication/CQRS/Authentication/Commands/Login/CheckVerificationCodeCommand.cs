using InfrastructureService;
using MediatR;

namespace IdentityApplication.CQRS.Authentication.Commands.Login;

public class CheckVerificationCodeCommand : IRequest<ResponseMessage>
{
    public string Username { get; set; }
    public string VerificationCode { get; set; }
}
