using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDomain.Common;

namespace TestApplication.Contracts.Repositories.Read
{
    public interface IBaseReadRepository<TModel, TKey> : IDisposable where TModel : BaseEntity<TKey>
    {
        Task<TModel> Get(TKey id, CancellationToken cancellationToken);
        Task<List<TModel>> GetAll(CancellationToken cancellationToken);
    }
}
