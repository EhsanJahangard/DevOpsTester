using AuthenticationDomain;
using AuthenticationRepository.Context;
using AuthenticationRepository.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationRepository.Repositories.Implementations
{
    public class RefreshTokenRepository : Repository<RefreshToken>, IRefreshTokenRepository
    {
        public RefreshTokenRepository(IdentityDBContext dbContext) : base(dbContext)
        {
        }

        public async Task AddAsync(RefreshToken refreshToken)
        {
            await _dbSet.AddAsync(refreshToken);    
        }

        public async Task<RefreshToken> GetByUserIdAsync(Guid userId)
        {
            return await _dbSet.Where(x=>x.UserId == userId).SingleOrDefaultAsync();    
        }
    }
}
