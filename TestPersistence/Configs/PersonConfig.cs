using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestDomain.Models;
namespace TestPersistence.Configs
{
    public class PersonConfig : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.Property(r => r.Id)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("NEWID()");

            //builder
            //        .HasOne(cargo => cargo.)
            //        .withon()
            //        .HasForeignKey(cargo => cargo.CargoDeclarationBaseStatusId)
            //        .OnDelete(DeleteBehavior.Restrict); // ON DELETE NO ACTION

            //builder
            //        .HasOne(cargo => cargo.CargoOwner)
            //        .WithMany()
            //        .HasForeignKey(cargo => cargo.CargoOwnerId)
            //        .OnDelete(DeleteBehavior.Restrict); // ON DELETE NO ACTION

            //builder
            //        .HasMany(cargo => cargo.CargoDeclarations)
            //        .WithOne(declaration => declaration.CargoDeclarationBase)
            //        .HasForeignKey(declaration => declaration.CargoDeclarationBaseId)
            //        .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
