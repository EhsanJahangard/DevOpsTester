using IdentityApplication.Contracts.Repositories;
using IdentityApplication.Contracts.UnitOfWork;
using IdentityDomain.Models;
using IdentityPersistence.Contexts;
using IdentityPersistence.Impelementations.Repositories;
using IdentityPersistence.Impelementations.UnitOfWork;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Reflection;
using System.Text;

namespace IdentityPersistence;
public static class PersistenceServiceRegistration
{
    public static void ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        #region ConnectionString

        var _connectionStringSql = configuration.GetConnectionString("SqlServerIdentity");
        var _connectionStringNgp = configuration.GetConnectionString("NpgIdentity");

        //for sql server
        // services.AddDbContext<IdentityDBContext>(options =>
        //     options.UseSqlServer(_connectionStringSql, b => b.MigrationsAssembly(Assembly.GetExecutingAssembly().GetName().Name)));

        //for postgresql
        services.AddDbContext<IdentityDBContext>(options =>
                 options.UseNpgsql(_connectionStringNgp, b => b.MigrationsAssembly(Assembly.GetExecutingAssembly().GetName().Name))
        );

        services.AddIdentity<User, Role>((IdentityOptions options) => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<IdentityDBContext>();


        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = configuration["Jwt:Issuer"],
                ValidAudience = configuration["Jwt:Audience"],
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:SignKey"])),
                TokenDecryptionKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:EncryptKey"]))
            };
        });

        services.Configure<IdentityOptions>(options =>
        {
            // Password settings.
            options.Password.RequireDigit = true;
            options.Password.RequireLowercase = true;
            options.Password.RequireNonAlphanumeric = true;
            options.Password.RequireUppercase = true;
            options.Password.RequiredLength = 6;
            options.Password.RequiredUniqueChars = 1;

            // Lockout settings.
            options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
            options.Lockout.MaxFailedAccessAttempts = 5;
            options.Lockout.AllowedForNewUsers = true;

            // User settings.
            options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
            options.User.RequireUniqueEmail = false;
        });

        services.ConfigureApplicationCookie(options =>
        {
            // Cookie settings
            options.Cookie.HttpOnly = true;
            options.ExpireTimeSpan = TimeSpan.FromMinutes(5);
        });


        #endregion

        #region RegisterRepositories
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

        services.AddScoped<IPermissionRepository, PermissionRepository>();
        services.AddScoped<IRefreshTokenRepository, RefreshTokenRepository>();
        services.AddScoped<ITokenManagerRepository, TokenManagerRepository>();
        services.AddScoped<IVerificationCodeRepository, VerificationCodeRepository>();
        #endregion


        #region UnitOfWorkRegister

        services.AddScoped<IUnitOfWork, UnitOfWork>();

        #endregion
    }


}