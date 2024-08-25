using TestDomain.Common;

namespace TestApplication.Contracts.Repositories
{

    public interface IBaseRepository<TModel, TKey> : IDisposable where TModel : BaseEntity<TKey>
    {
        void Create(TModel entity);
        void Update(TModel entity);
        void Delete(TModel entity);
        Task<TModel> Get(TKey id, CancellationToken cancellationToken);
        Task<List<TModel>> GetAll(CancellationToken cancellationToken);
    }
}
