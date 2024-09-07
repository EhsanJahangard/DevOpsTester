using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestDomain.Models;

namespace TestPersistence.Configs;

public class LevelConfig : IEntityTypeConfiguration<Level>
{
    public void Configure(EntityTypeBuilder<Level> builder)
    {
        builder.Property(r => r.Id)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("NEWID()");
        builder.Property(r => r.Title)
              .HasMaxLength(400);

    }
}

public class PhotoConfig : IEntityTypeConfiguration<Photo>
{
    public void Configure(EntityTypeBuilder<Photo> builder)
    {
        builder.Property(r => r.Id)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("NEWID()");
        builder.Property(r => r.Title)
              .HasMaxLength(400);
        builder.Property(r => r.Url)
              .HasMaxLength(900);

    }
}
