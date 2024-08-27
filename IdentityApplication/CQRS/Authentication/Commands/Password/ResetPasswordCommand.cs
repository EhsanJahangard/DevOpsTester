using InfrastructureService;
using MediatR;

namespace IdentityApplication.CQRS.Authentication.Commands.Password;

public class ResetPasswordCommand : IRequest<ResponseMessage>
{
    public string UserId { get; set; }
    public string? Sender { get; set; }
}
