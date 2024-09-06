using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestDomain.Models;

namespace TestPersistence.Configs;

public class MasterConfig : IEntityTypeConfiguration<Master>
{
    public void Configure(EntityTypeBuilder<Master> builder)
    {
        builder.Property(r => r.Id)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("NEWID()");
        builder.Property(r => r.Name)
              .HasMaxLength(150);
        builder.Property(r => r.Family)
             .HasMaxLength(150);
        builder.Property(r => r.Mobile)
           .HasMaxLength(11);
        
    }
}
