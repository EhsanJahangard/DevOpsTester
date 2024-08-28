using IdentityApplication.Contracts.Repositories;
using IdentityDomain.Models;
using IdentityPersistence.Contexts;
using Microsoft.EntityFrameworkCore;
namespace IdentityPersistence.Impelementations.Repositories;

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
        return await _dbSet.Where(x => x.Username == username).SingleOrDefaultAsync();
    }
}