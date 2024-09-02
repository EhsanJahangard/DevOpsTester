using MongoDB.Driver;
using NotificationDomain.Models;

namespace NotificationPersistence.Context;


public class MongoDBContext
{
    private readonly IMongoDatabase _database;

    public MongoDBContext(string connectionString, string databaseName)
    {
        var client = new MongoClient(connectionString);
        _database = client.GetDatabase(databaseName);
    }

    public IMongoCollection<Sms> Products => _database.GetCollection<Sms>("Sms");
}