using LisbagServer.Domain.Entities.UserProfileAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LisbagServer.Infra.Dal.EntitiesConfiguration;

public class PhoneConfiguration : IEntityTypeConfiguration<Phone>
{
    public void Configure(EntityTypeBuilder<Phone> builder)
    {
        builder.ToTable(nameof(Phone).ToLower());

        builder.HasKey(x => x.Id);

        builder.Property(x => x.InternationalAreaCode)
            .HasMaxLength(2)
            .IsRequired();

        builder.Property(x => x.Prefix)
            .HasMaxLength(2)
            .IsRequired();

        builder.Property(x => x.Number)
            .HasMaxLength(9)
            .IsRequired();
    }
}
