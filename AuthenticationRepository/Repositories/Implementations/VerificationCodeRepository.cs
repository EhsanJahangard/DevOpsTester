using AuthenticationDomain;
using AuthenticationRepository.Context;
using AuthenticationRepository.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationRepository.Repositories.Implementations
{
    public class VerificationCodeRepository : Repository<VerificationCode>, IVerificationCodeRepository
    {
        public VerificationCodeRepository(IdentityDBContext dbContext) : base(dbContext)
        {
        }

        public async Task AddAsync(VerificationCode verificationCode)
        {
            await _dbSet.AddAsync(verificationCode);
        }

        public async Task<VerificationCode> GetByUsernameAsync(string username)
        {
            return await _dbSet.Where(x=>x.Username == username).SingleOrDefaultAsync();
        }
    }
}
