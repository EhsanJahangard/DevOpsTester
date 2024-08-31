using Microsoft.EntityFrameworkCore;
using NotificationPersistence.Configs;
using System.Reflection;

namespace NotificationPersistence.Contexts;

public class NotificationContext : DbContext
{
    public NotificationContext(DbContextOptions<NotificationContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(SmsConfig)));
    }
}
