using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPersistence.Impelementations.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext context;
        public UnitOfWork(DatabaseContext context)
        {
            this.context = context;
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }

    }
}
