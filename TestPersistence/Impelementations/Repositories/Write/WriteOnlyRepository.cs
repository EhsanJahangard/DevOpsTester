using Microsoft.EntityFrameworkCore;
using TestPersistence.Contexts;
using TestApplication.Contracts.Repositories.Write;

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
    public async Task AddAsync(T t)
    {
        await DbSet.AddAsync(t);
    }

    public void Delete(T t)
    {
        DbSet.Remove(t);
    }

}
