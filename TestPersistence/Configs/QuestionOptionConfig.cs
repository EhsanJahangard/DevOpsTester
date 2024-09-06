using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestDomain.Models;
namespace TestPersistence.Configs;

public class QuestionOptionConfig : IEntityTypeConfiguration<QuestionOption>
{
    public void Configure(EntityTypeBuilder<QuestionOption> builder)
    {
        builder.Property(r => r.Id)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("NEWID()");


    }
}
