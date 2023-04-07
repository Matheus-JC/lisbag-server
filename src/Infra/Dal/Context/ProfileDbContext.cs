using LisbagServer.Domain.Entities;
using LisbagServer.Domain.Entities.ProfileAggregate;
using LisbagServer.Infra.Dal.EntitiesConfiguration;
using Microsoft.EntityFrameworkCore;

namespace LisbagServer.Infra.Dal.Context;

public sealed class ProfileDbContext : DbContext
{
    public ProfileDbContext(DbContextOptions<ProfileDbContext> options) : base(options)
    {}

    public DbSet<Profile> Profiles { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Phone> Phones { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.HasDefaultSchema("profile");
        builder.ApplyConfiguration(new ProfileConfiguration());
        builder.ApplyConfiguration(new AddressConfiguration());
        builder.ApplyConfiguration(new PhoneConfiguration());
    }
}
