using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDomain.Models;

namespace TestPersistence.Configs
{
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
}
