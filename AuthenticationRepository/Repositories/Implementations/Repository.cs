using AuthenticationRepository.Context;
using AuthenticationRepository.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationRepository.Repositories.Implementations
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly IdentityDBContext _dbContext;
        protected DbSet<T> _dbSet;
        public Repository(IdentityDBContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }
    }
}
