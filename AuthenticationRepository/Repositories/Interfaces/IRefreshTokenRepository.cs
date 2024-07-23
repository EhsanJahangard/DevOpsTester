using AuthenticationDomain;

namespace AuthenticationRepository.Repositories.Interfaces
{
    public interface IRefreshTokenRepository : IRepository<RefreshToken>
    {
        Task<RefreshToken> GetByUserIdAsync(Guid userId);

        Task AddAsync(RefreshToken refreshToken);
    }
}
