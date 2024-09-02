using InfrastructureService;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using NotificationApplication.Contracts.Repositories;
using NotificationDomain.Models;
using NotificationPersistence.Context;
using NotificationPersistence.Impelementations;



namespace NotificationPersistence;
public static class PersistenceServiceRegistration
{
    public static void ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {

        // Add connection string
        services.Configure<MongoDBSettings>(configuration.GetSection("MongoDBSettings"));

        // Register mongoDb configuration as a singleton object
        services.AddSingleton<IMongoDatabase>(options => {
            var settings = configuration.GetSection("MongoDBSettings").Get<MongoDBSettings>();
            var client = new MongoClient(settings.ConnectionString);
            return client.GetDatabase(settings.DatabaseName);
        });
        services.AddScoped<ISmsRepository,SmsRepository>();
        

    }
}

