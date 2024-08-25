using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.Contracts.Repositories.Write
{
    public interface IWriteOnlyRepository<T>
    {
        Task<T> GetByIdAsync(int id);
        Task<T> GetByIdLongAsync(long id);
        Task AddAsync(T t);
        void Delete(T t);
        Task SaveChangesAsync();
    }
}
