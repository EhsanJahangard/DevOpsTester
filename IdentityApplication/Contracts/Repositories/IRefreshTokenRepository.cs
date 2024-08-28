namespace IdentityApplication.Contracts.Repositories;

public interface IRefreshTokenRepository : IRepository<IdentityDomain.Models.RefreshToken>
{
    Task<IdentityDomain.Models.RefreshToken> GetByUserIdAsync(Guid userId);

    Task AddAsync(IdentityDomain.Models.RefreshToken refreshToken);
}
