using TestApplication.Contracts.UnitOfWork;
using TestPersistence.Contexts;

namespace TestPersistence.Impelementations.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly DevOpsTesterContext context;
    public UnitOfWork(DevOpsTesterContext context)
    {
        this.context = context;
    }

    public async Task Save(CancellationToken cancellationToke)
    {
        await context.SaveChangesAsync();
    }

  
}
