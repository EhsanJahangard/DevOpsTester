namespace TestApplication.Contracts.Repositories.Write
{
    public interface IWriteOnlyRepository<T>
    {
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
