using InfrastructureService;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using NotificationApplication.Contracts.Repositories;
using NotificationPersistence.Impelementations;


namespace NotificationPersistence;
public static class PersistenceServiceRegistration
{
    public static void ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {

        // MongoDB configuration
        var mongoDbSettings = configuration.GetSection("MongoDBSettings").Get<MongoDBSettings>();
        var client = new MongoClient(mongoDbSettings.ConnectionString);
        var database = client.GetDatabase(mongoDbSettings.DatabaseName);

        // Register the MongoDB context or direct collections
        services.AddSingleton<IMongoDatabase>(database);

        // Register the generic repository for dependency injection
        services.AddScoped(typeof(IMongoRepository<>), typeof(MongoRepository<>));


        //// Bind MongoDB settings
        //services.Configure<MongoDBSettings>(
        // configuration.GetSection("MongoDBSettings"));

        //// Register MongoDB client as a singleton
        //services.AddSingleton<IMongoClient, MongoClient>(sp =>
        //{
        //    var settings = sp.GetRequiredService<IOptions<MongoDBSettings>>().Value;
        //    return new MongoClient(settings.ConnectionString);
        //});

        //// Register the service that will use the MongoDB
        //services.AddScoped<IMongoDatabase>(sp =>
        //{
        //    var settings = sp.GetRequiredService<IOptions<MongoDBSettings>>().Value;
        //    var client = sp.GetRequiredService<IMongoClient>();
        //    return client.GetDatabase(settings.DatabaseName);
        //});


        //#region ConnectionString

        //var _connectionString = configuration.GetConnectionString("SqlServer");
        //services.AddDbContext<NotificationContext>(options =>
        //    options.UseSqlServer(_connectionString, b => b.MigrationsAssembly(Assembly.GetExecutingAssembly().GetName().Name)));
        //#endregion

        //#region RegisterRepositories

        //services.AddScoped<IReadOnlyRepository, ReadOnlyRepository>();

        //services.AddScoped(typeof(IWriteOnlyRepository<>), typeof(WriteOnlyRepository<>));


        //#endregion

    }
}

