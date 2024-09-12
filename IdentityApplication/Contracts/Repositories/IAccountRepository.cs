using IdentityApplication.DTOs.Login;
using IdentityDomain.Models;
using System.Security.Claims;

namespace IdentityApplication.Contracts.Repositories;

public interface IAccountRepository : IRepository<IdentityDomain.Models.RefreshToken>
{
    public Task<GenerateTokenDto> GenerateToken(User user, List<Claim> claims);
}
