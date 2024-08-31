using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NotificationApplication.Contracts.Repositories;
using NotificationPersistence.Contexts;
using NotificationPersistence.Impelementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NotificationPersistence;
public static class PersistenceServiceRegistration
{

    public static void ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        #region ConnectionString

        var _connectionString = configuration.GetConnectionString("SqlServer");
        services.AddDbContext<NotificationContext>(options =>
            options.UseSqlServer(_connectionString, b => b.MigrationsAssembly(Assembly.GetExecutingAssembly().GetName().Name)));
        #endregion

        #region RegisterRepositories

        services.AddScoped<IReadOnlyRepository, ReadOnlyRepository>();

        services.AddScoped(typeof(IWriteOnlyRepository<>), typeof(WriteOnlyRepository<>));


        #endregion
        //#region UnitOfWorkRegister

        //services.AddScoped<IUnitOfWork, UnitOfWork>();

        //#endregion
    }
}

