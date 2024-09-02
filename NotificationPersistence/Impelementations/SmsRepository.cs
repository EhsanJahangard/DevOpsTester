using MongoDB.Bson;
using MongoDB.Driver;
using NotificationApplication.Contracts.Repositories;
using NotificationDomain.Models;
namespace NotificationPersistence.Impelementations;

public class SmsRepository : ISmsRepository
{
    private readonly IMongoCollection<Sms> _collection;


    public SmsRepository(IMongoDatabase database)
    {

        _collection = database.GetCollection<Sms>("sms");
    }

    public async Task<List<Sms>> GetAllAsync()
    {
        return await _collection.Find(new BsonDocument()).ToListAsync();
    }

    public async Task<Sms> GetByIdAsync(string id)
    {
        return await _collection.Find(Builders<Sms>.Filter.Eq("_id", new ObjectId(id))).FirstOrDefaultAsync();
    }

    public async Task AddAsync(Sms entity)
    {
        await _collection.InsertOneAsync(entity);
    }

    public async Task UpdateAsync(string id, Sms entity)
    {
        await _collection.ReplaceOneAsync(Builders<Sms>.Filter.Eq("_id", new ObjectId(id)), entity);
    }

    public async Task DeleteAsync(string id)
    {
        await _collection.DeleteOneAsync(Builders<Sms>.Filter.Eq("_id", new ObjectId(id)));
    }
}