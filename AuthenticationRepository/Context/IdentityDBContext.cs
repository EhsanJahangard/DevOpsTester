using AuthenticationDomain;
using AuthenticationRepository.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AuthenticationRepository.Context
{
    public class IdentityDBContext : IdentityDbContext<User,Role,string> 
    {
        public IdentityDBContext(DbContextOptions<IdentityDBContext> options) : base(options) 
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(typeof(PermissionConfiguration).Assembly);
        }
    }
}
