using Microsoft.EntityFrameworkCore;
using TestPersistence.Contexts;
using TestPersistence.Interfaces.Write;

namespace TestPersistence.Impelementations.Repositories.Write;

public class WriteOnlyRepository<T> : IWriteOnlyRepository<T> where T : class
{
    private readonly DevOpsTesterContext _databaseContext;
    private DbSet<T> DbSet;

    public WriteOnlyRepository(DevOpsTesterContext databaseContext)
    {
        _databaseContext = databaseContext;
        DbSet = _databaseContext.Set<T>();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await DbSet.FindAsync(id);
    }
    public async Task<T> GetByIdLongAsync(long id)
    {
        return await DbSet.FindAsync(id);
    }

    public async Task AddAsync(T t)
    {
        await DbSet.AddAsync(t);
    }

    public void Delete(T t)
    {
        DbSet.Remove(t);
    }

    public async Task SaveChangesAsync()
    {
        await _databaseContext.SaveChangesAsync();
    }

}
