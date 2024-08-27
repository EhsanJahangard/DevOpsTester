using IdentityApplication.CQRS.Authentication.Commands.Token;
using InfrastructureService;
using MediatR;
using System.Net;
using System.Security.Claims;

namespace IdentityApplication.CQRS.Authentication.CommandHandlers;

internal class TokenCommandHandler : IRequestHandler<GenereateRefreshTokenCommand, ResponseMessage>
{
    private readonly ITokenManager _tokenManager;
    private readonly IRefreshTokenRepository _refreshTokenRepository;

    public TokenCommandHandler(ITokenManager tokenManager, IRefreshTokenRepository refreshTokenRepository)
    {
        _tokenManager = tokenManager;
        _refreshTokenRepository = refreshTokenRepository;
    }

    public async Task<ResponseMessage> Handle(GenereateRefreshTokenCommand request, CancellationToken cancellationToken)
    {
        try
        {
            ClaimsPrincipal claimsPrincipal = _tokenManager.DecodeToken(request.AccessToken);

            if (claimsPrincipal is null)
                return new ResponseMessage(HttpStatusCode.Unauthorized);

            string userId = claimsPrincipal.Claims.Where(x => x.Type == "UserId").Select(x => x.Value).FirstOrDefault();


            bool isValidRefreshToken = await _tokenManager.IsValidRefreshTokenAsync(request.RefreshToken, userId);

            if (!isValidRefreshToken)
                return new ResponseMessage(HttpStatusCode.Unauthorized);

            string username = claimsPrincipal.Claims.Where(x => x.Type == ClaimTypes.Name).Select(x => x.Value).FirstOrDefault();
            IList<string> userRole = claimsPrincipal.Claims.Where(x => x.Type == "UserRoles").Select(x => x.Value).ToList();
            IList<string> userPermissions = claimsPrincipal.Claims.Where(x => x.Type == "UserPermissions").Select(x => x.Value).ToList();

            string refreshToken = await _tokenManager.GenerateRefreshTokenAsync(userId);

            string accessToken = _tokenManager.GenerateToken(userId, username, userRole, userPermissions);

            GenerateRefreshTokenDto dto = new GenerateRefreshTokenDto() { AccessToken = accessToken, RefreshToken = refreshToken };

            return new ResponseMessage(dto);
        }
        catch (Exception ex)
        {
            return new ResponseMessage(ex.Message);
        }

    }
}