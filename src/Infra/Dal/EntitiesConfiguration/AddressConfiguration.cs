using LisbagServer.Domain.Entities.UserProfileAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LisbagServer.Infra.Dal.EntitiesConfiguration;

public class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.ToTable(nameof(Address).ToLower());

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .HasMaxLength(100)
            .IsRequired();

        builder.OwnsOne(x => x.PostalCode)
            .Property(x => x.Value)
            .HasColumnName("postal_code")
            .HasMaxLength(8)
            .IsRequired();

        builder.Property(x => x.City)
            .HasMaxLength(50);

        builder.Property(x => x.State)
            .HasMaxLength(50);

        builder.Property(x => x.Country)
            .HasMaxLength(50);

        builder.Property(c => c.Type)
            .HasConversion<int>();
    }
}
