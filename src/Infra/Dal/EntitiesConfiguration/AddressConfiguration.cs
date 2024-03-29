﻿using LisbagServer.Domain.Entities.ProfileAggregate;
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

        builder.Property(x => x.PostalCode)
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

        //string profileFkName = "ProfileId";

        //builder.Property<int> (profileFkName);
        //builder.HasOne<Profile>()
        //    .WithMany()
        //    .HasForeignKey(profileFkName);
    }
}
