using Microsoft.EntityFrameworkCore;
using NotificationApplication.Contracts.Repositories;
using NotificationPersistence.Contexts;

namespace NotificationPersistence.Impelementations;

public class WriteOnlyRepository<T> : IWriteOnlyRepository<T> where T : class
{
    private readonly NotificationContext _context;
    private DbSet<T> DbSet;

    public WriteOnlyRepository(NotificationContext context)
    {
        _context = context;
        DbSet = _context.Set<T>();
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
        await _context.SaveChangesAsync();
    }
}
