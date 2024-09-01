namespace NotificationApplication.Contracts.Repositories;

public interface IWriteOnlyRepository<T>
{
    Task<T> GetByIdAsync(int id);
    Task<T> GetByIdLongAsync(long id);
    Task AddAsync(T t);
    void Delete(T t);
    Task SaveChangesAsync();
}
