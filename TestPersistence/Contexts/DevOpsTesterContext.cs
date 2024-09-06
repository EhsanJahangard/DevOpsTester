using Microsoft.EntityFrameworkCore;
using System.Data;
using TestDomain.Common;
using TestDomain.Models;
using TestPersistence.Configs;
using TestPersistence.Seed;

namespace TestPersistence.Contexts;

public class DevOpsTesterContext : DbContext
{
    public DevOpsTesterContext(DbContextOptions<DevOpsTesterContext> options)
     : base(options)
    {

    }
    public DbSet<Photo> Photos { get; set; }
    public DbSet<Person> People { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<Level> Levels { get; set; }
    public DbSet<QuestionType> QuestionTypes { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<QuestionPhoto> QuestionPhotos { get; set; }
    public DbSet<QuestionOption> QuestionOptions { get; set; }
    public DbSet<PersonSkill> PersonSkills { get; set; }
    public DbSet<Master> Masters { get; set ; }
    public DbSet<TestQuestion> TestQuestions { get; set; }
    public DbSet<Test> Tests { get; set; }
    public DbSet<TestResult> TestResults { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        Config(builder);
        builder.Seed();
      
    }

    private static void Config(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PersonConfig).Assembly);
        
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
