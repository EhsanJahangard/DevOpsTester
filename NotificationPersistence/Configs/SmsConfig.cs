using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotificationDomain.Models;


namespace NotificationPersistence.Configs;


public class SmsConfig : IEntityTypeConfiguration<Sms>
{
    public void Configure(EntityTypeBuilder<Sms> builder)
    {
        builder.ToTable("Sms");
    }
}
