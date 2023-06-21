using LisbagServer.Domain.Entities.UserProfileAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LisbagServer.Infra.Dal.EntitiesConfiguration;

public class UserProfileConfiguration : IEntityTypeConfiguration<UserProfile>
{
    public void Configure(EntityTypeBuilder<UserProfile> builder)
    {
        builder.ToTable("user_profile");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(x => x.Surname)
            .HasMaxLength(50)
            .IsRequired();

        builder.OwnsOne(x => x.Email)
            .Property(x => x.Value)
            .HasColumnName("email")
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(x => x.DateOfBirth);

        builder.HasMany(b => b.Addresses)
            .WithOne();

        builder.HasMany(b => b.Phones)
            .WithOne();
    }
}
