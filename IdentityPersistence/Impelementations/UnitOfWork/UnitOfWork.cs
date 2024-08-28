using IdentityApplication.Contracts.UnitOfWork;
using IdentityPersistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityPersistence.Impelementations.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly IdentityDBContext context;
    public UnitOfWork(IdentityDBContext context)
    {
        this.context = context;
    }

    public async Task<int> Save()
    {
       return await context.SaveChangesAsync();
    }


}