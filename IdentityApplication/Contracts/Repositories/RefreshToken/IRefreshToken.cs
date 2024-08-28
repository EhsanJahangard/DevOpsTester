namespace IdentityApplication.Contracts.Repositories.RefreshToken;

public interface IRefreshToken : IRepository<IdentityDomain.Models.RefreshToken>
{
    Task<IdentityDomain.Models.RefreshToken> GetByUserIdAsync(Guid userId);

    Task AddAsync(IdentityDomain.Models.RefreshToken refreshToken);
}
