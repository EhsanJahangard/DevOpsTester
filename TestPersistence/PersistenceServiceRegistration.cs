﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPersistence.Contexts;

namespace TestPersistence
{
    public static class PersistenceServiceRegistration
    {
        public static void ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            #region ConnectionString

            services.AddDbContext<DevOpsTesterContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("SqlServer")));

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
