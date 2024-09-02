using NotificationDomain.Models;

namespace NotificationApplication.Contracts.Repositories;

public interface ISmsRepository
{
    Task<List<Sms>> GetAllAsync();
    Task<Sms> GetByIdAsync(string id);
    Task AddAsync(Sms entity);
    Task UpdateAsync(string id, Sms entity);
    Task DeleteAsync(string id);
}