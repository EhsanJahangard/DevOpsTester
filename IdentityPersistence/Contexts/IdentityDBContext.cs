using IdentityDomain.Models;
using IdentityPersistence.Configs;
using IdentityPersistence.Seed;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection.Emit;

namespace IdentityPersistence.Contexts;

public class IdentityDBContext : IdentityDbContext<User, Role, string>
{
    public IdentityDBContext() { } // This one
    public IdentityDBContext(DbContextOptions<IdentityDBContext> options) : base(options)
    {

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
        }
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        builder.ApplyConfigurationsFromAssembly(typeof(PermissionConfig).Assembly);
        builder.Seed();
    }
}
