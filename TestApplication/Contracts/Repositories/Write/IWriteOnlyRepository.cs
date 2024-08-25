namespace TestApplication.Contracts.Repositories.Write
{
    public interface IWriteOnlyRepository<T>
    {
        Task AddAsync(T t);
        void Delete(T t);
    }
}
