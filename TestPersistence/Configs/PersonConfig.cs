﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestDomain.Models;
namespace TestPersistence.Configs;

public class PersonConfig : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.Property(r => r.Id)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("NEWID()");

        builder.Property(r => r.Name)
              .HasMaxLength(400);

        builder.Property(r => r.Family)
            .HasMaxLength(400);
        builder.Property(r => r.Mobile)
         .HasMaxLength(11);

       
    }
}
