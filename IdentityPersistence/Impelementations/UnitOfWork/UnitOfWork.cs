using IdentityApplication.Contracts.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityPersistence.Impelementations.UnitOfWork;

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