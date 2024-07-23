using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDomain.Common;
using TestDomain.Models;
using TestPersistence.Configs;

namespace TestPersistence.Contexts;

public class DevOpsTesterContext : DbContext
{
    public DevOpsTesterContext(DbContextOptions<DevOpsTesterContext> options)
     : base(options)
    {

    }

    public DbSet<TestResult> TestResults { get; set; }
    public DbSet<Test> Tests { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<QuestionOptions> QuestionOptions { get; set; }
    public DbSet<QuestionPhoto> QuestionPhotos { get; set; }
    public DbSet<QuestionType> QuestionTypes { get; set; }
    public DbSet<Photo> Photos { get; set; }
    public DbSet<Person> People { get; set; }
    public DbSet<PersonSkills> PersonSkills { get; set; }
    public DbSet<Level> Levels { get; set; }
    public DbSet<Skill> Skills { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        Config(builder);
    }

    private static void Config(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PersonConfig());
       

        //modelBuilder.SharedTypeEntity<Dictionary<string, object>>("PermissionRole", builder =>
        //{
        //    builder.HasKey("PermissionsId", "RolesId");

        //    // Add the UserId column
        //    builder.Property<Guid>("UserId")
        //           .IsRequired();

        //    // Establish the foreign key relationship with the Users table
        //    builder.HasOne<User>()
        //           .WithMany()
        //           .HasForeignKey("UserId");

        //    builder.HasKey("PermissionsId", "RolesId", "UserId");
        //});
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        foreach (var entry in ChangeTracker.Entries().Where(e => e.Entity is BaseEntity<Guid>))
        {
            if (entry.State == EntityState.Added)
            {
                (entry.Entity as BaseEntity<Guid>).DateCreate = DateTime.Now;
            }
            if (entry.State == EntityState.Modified)
            {
                (entry.Entity as BaseEntity<Guid>).DateUpdate = DateTime.Now;
            }
        }
        return base.SaveChangesAsync(cancellationToken);
    }

    public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
    {
        foreach (var entry in ChangeTracker.Entries().Where(e => e.Entity is BaseEntity<Guid>))
        {
            if (entry.State == EntityState.Added)
            {
                (entry.Entity as BaseEntity<Guid>).DateCreate = DateTime.Now;
            }
            if (entry.State == EntityState.Modified)
            {
                (entry.Entity as BaseEntity<Guid>).DateUpdate = DateTime.Now;
            }
        }
        return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
    }

}
