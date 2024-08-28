using System.Security.Claims;

namespace IdentityApplication.Contracts.Repositories.TokenManagers;

public interface ITokenManager 
{
    string GenerateToken(string userId, string username, IList<string> userRoles, IList<string> userPermissions);
    Task<string> GenerateRefreshTokenAsync(string userId);
    ClaimsPrincipal DecodeToken(string token);
    Task<bool> IsValidRefreshTokenAsync(string inputRefreshToken, string userId);
}
