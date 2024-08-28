using IdentityDomain.Models;
using IdentityPersistence.Configs;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityPersistence.Contexts;

public class IdentityDBContext : IdentityDbContext<User, Role, string>
{
    public IdentityDBContext(DbContextOptions<IdentityDBContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfigurationsFromAssembly(typeof(PermissionConfig).Assembly);
    }
}
