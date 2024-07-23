using AuthenticationApplication.TokenManagers;
using AuthenticationRepository.Repositories.Implementations;
using AuthenticationRepository.Repositories.Interfaces;

namespace AuthenticationService.DI
{
    public static class Register
    {
        public static void RegisterDI(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
            services.AddScoped<IUnitOfWork,UnitOfWork>();
            services.AddScoped<IPermissionRepository,PermissionRepository>();
            services.AddScoped<ITokenManager,TokenManager>();
            services.AddScoped<IRefreshTokenRepository,RefreshTokenRepository>();
            services.AddScoped<IVerificationCodeRepository, VerificationCodeRepository>();
        }
    }
}
