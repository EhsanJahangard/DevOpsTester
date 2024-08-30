using IdentityDomain.Models;
using IdentityPersistence.Configs;
using IdentityPersistence.Seed;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
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

        //برای مشکل postgresql
        //var dateTimeConverter = new ValueConverter<DateTime, DateTime>(
        //        v => v.ToUniversalTime(),   // تبدیل DateTime به UTC برای ذخیره‌سازی
        //            v => DateTime.SpecifyKind(v, DateTimeKind.Utc) // تبدیل دوباره به UTC هنگام بازیابی
                                                                 //); 
      
        //foreach (var entityType in builder.Model.GetEntityTypes())
        //{
        //    var properties = entityType.ClrType.GetProperties()
        //        .Where(p => p.PropertyType == typeof(DateTime) || p.PropertyType == typeof(DateTime?));

        //    foreach (var property in properties)
        //    {
        //        builder.Entity(entityType.Name).Property(property.Name)
        //            .HasConversion(dateTimeConverter);
        //    }
        //}
        builder.ApplyConfigurationsFromAssembly(typeof(PermissionConfig).Assembly);
        builder.Seed();
        base.OnModelCreating(builder);
    }
}
