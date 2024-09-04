using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestDomain.Models;
namespace TestPersistence.Configs;

public class QuestionConfig : IEntityTypeConfiguration<Question>
{
    public void Configure(EntityTypeBuilder<Question> builder)
    {
        builder.Property(r => r.Id)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("NEWID()");

        builder.Property(r => r.Letter)
              .HasMaxLength(400);

        builder.Property(r => r.Answer)
            .HasMaxLength(800);

    }
}
