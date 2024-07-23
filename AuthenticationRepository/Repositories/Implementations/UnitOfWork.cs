using AuthenticationRepository.Context;
using AuthenticationRepository.Repositories.Interfaces;

namespace AuthenticationRepository.Repositories.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IdentityDBContext _dbContext;

        public UnitOfWork(IdentityDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
