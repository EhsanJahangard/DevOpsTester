using IdentityApplication.Contracts.Repositories;
using IdentityPersistence.Contexts;
using Microsoft.EntityFrameworkCore;
namespace IdentityPersistence.Impelementations.Repositories;

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