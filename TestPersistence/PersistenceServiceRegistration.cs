using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.Contracts.Repositories.Write;
using TestApplication.Contracts.UnitOfWork;
using TestPersistence.Contexts;
using TestPersistence.Impelementations.Repositories.Read;
using TestPersistence.Impelementations.Repositories.Write;
using TestPersistence.Impelementations.UnitOfWork;

namespace TestPersistence;


public static class PersistenceServiceRegistration
{
    public static void ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        #region ConnectionString

        var _connectionString = configuration.GetConnectionString("SqlServer");
        services.AddDbContext<DevOpsTesterContext>(options =>
            options.UseSqlServer(_connectionString, b => b.MigrationsAssembly(Assembly.GetExecutingAssembly().GetName().Name)));
        #endregion

        #region RegisterRepositories

        services.AddScoped<IReadOnlyRepository, ReadOnlyRepository>();

        services.AddScoped(typeof(IWriteOnlyRepository<>), typeof(WriteOnlyRepository<>));

        services.AddScoped<ILevelReadRepository, LevelReadRepository>();
        services.AddScoped<IPersonReadRepository, PersonReadRepository>();
        services.AddScoped<IQuestionReadRepository, QuestionReadRepository>();
        services.AddScoped<ISkillReadRepository, SkillReadRepository>();
        services.AddScoped<ITestQuestionReadRepository, TestQuestionReadRepository>();
        #endregion
        #region Redis
        //services.AddStackExchangeRedisCache(options =>
        //{
        //    options.Configuration =configuration.GetValue<string>("CacheSettings:ConnectionString");
        //});
        services.AddStackExchangeRedisCache(options =>
        {
            options.Configuration = configuration.GetValue<string>("CacheSettings:ConnectionString");
            options.ConfigurationOptions = new StackExchange.Redis.ConfigurationOptions()
            {
                AbortOnConnectFail = true,
                EndPoints = { options.Configuration }
            };
            options.InstanceName = "DevOps_";
        });

        //services.AddScoped<IDistributedCache, DistributedCache>();
        #endregion
        #region UnitOfWorkRegister

        services.AddScoped<IUnitOfWork, UnitOfWork>();

        #endregion
        
    }
   

}
