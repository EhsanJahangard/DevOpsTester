using Microsoft.EntityFrameworkCore;
using TestApplication.Contracts.Repositories.Write;
using TestPersistence.Contexts;

namespace TestPersistence.Impelementations.Repositories.Write;

public class WriteOnlyRepository<T> : IWriteOnlyRepository<T> where T : class
{
    private readonly DevOpsTesterContext context;
    private DbSet<T> DbSet;

    public WriteOnlyRepository(DevOpsTesterContext context)
    {
        this.context = context;
        DbSet = this.context.Set<T>();
    }
    public async Task AddAsync(T entity)
    {
        await DbSet.AddAsync(entity);
    }

    public void Delete(T entity)
    {
        DbSet.Remove(entity);
    }

    public void Update(T entity)
    {
        DbSet.Update(entity);
    }
}
