using InfrastructureService;
using MediatR;

namespace IdentityApplication.CQRS.Authentication.Commands.Token;

public class GenereateRefreshTokenCommand : IRequest<ResponseMessage>
{
    public string AccessToken { get; set; }
    public string RefreshToken { get; set; }
}
