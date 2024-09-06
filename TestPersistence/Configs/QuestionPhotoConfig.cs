using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestDomain.Models;
namespace TestPersistence.Configs;

public class QuestionPhotoConfig : IEntityTypeConfiguration<QuestionPhoto>
{
    public void Configure(EntityTypeBuilder<QuestionPhoto> builder)
    {
        builder.Property(r => r.Id)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("NEWID()");

       
    }
}
