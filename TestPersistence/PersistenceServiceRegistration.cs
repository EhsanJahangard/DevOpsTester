using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.Contracts.Repositories.Read;
using TestApplication.Contracts.Repositories.Write;
using TestApplication.Contracts.UnitOfWork;
using TestPersistence.Contexts;
using TestPersistence.Impelementations.Repositories.Read;
using TestPersistence.Impelementations.Repositories.Write;
using TestPersistence.Impelementations.UnitOfWork;

namespace TestPersistence
{
    public static class PersistenceServiceRegistration
    {
        public static void ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            #region ConnectionString
            var cnn = "Data Source=.;Initial Catalog=DevOpsTester;User ID=sa3;Password=11;MultipleActiveResultSets=true;TrustServerCertificate=True";
            services.AddDbContext<DevOpsTesterContext>(options =>
                options.UseSqlServer(cnn, b => b.MigrationsAssembly("TestEndPoint")));
            #endregion

            #region RegisterRepositories

            services.AddScoped<IReadOnlyRepository, ReadOnlyRepository>();

            services.AddScoped(typeof(IWriteOnlyRepository<>), typeof(WriteOnlyRepository<>));

            services.AddScoped<ILevelReadRepository, LevelReadRepository>();
            //services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            #endregion
            #region UnitOfWorkRegister

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            #endregion
        }
        //public static void ConfigurePersistence(this IServiceCollection services, IConfiguration configuration)
        //{
        //    var connectionString = configuration.GetConnectionString("Sqlite");
        //    services.AddDbContext<DataContext>(opt => opt.UseSqlite(connectionString));

        //    services.AddScoped<IUnitOfWork, UnitOfWork>();
        //    services.AddScoped<IUserRepository, UserRepository>();
        //}

    }

}
