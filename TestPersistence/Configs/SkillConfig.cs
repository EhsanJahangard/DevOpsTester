using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestDomain.Models;
namespace TestPersistence.Configs;

public class SkillConfig : IEntityTypeConfiguration<Skill>
{
    public void Configure(EntityTypeBuilder<Skill> builder)
    {
        builder.Property(r => r.Id)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("NEWID()");

        builder.Property(r => r.Title)
              .HasMaxLength(200);
    }
}
