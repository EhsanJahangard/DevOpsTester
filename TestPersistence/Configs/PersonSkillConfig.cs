using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestDomain.Models;
namespace TestPersistence.Configs;

public class PersonSkillConfig : IEntityTypeConfiguration<PersonSkill>
{
    public void Configure(EntityTypeBuilder<PersonSkill> builder)
    {
        builder.Property(r => r.Id)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("NEWID()");
    }
}
