using TestDomain.Common;

namespace TestApplication.Contracts.Repositories.Write
{

    public interface IBaseWriteRepository<TModel, TKey> : IDisposable where TModel : BaseEntity<TKey>
    {
        Task AddAsync(TModel entity);
        void Update(TModel entity);
        void Delete(TModel entity);

    }
}
