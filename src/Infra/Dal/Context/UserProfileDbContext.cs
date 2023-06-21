using LisbagServer.Domain.Entities.UserProfileAggregate;
using LisbagServer.Domain.Enums;
using LisbagServer.Infra.Dal.EntitiesConfiguration;
using Microsoft.EntityFrameworkCore;

namespace LisbagServer.Infra.Dal.Context;

public sealed class UserProfileDbContext : DbContext
{
    public DbSet<UserProfile> UserProfiles { get; set; } = null!;
    public DbSet<Address> Addresses { get; set; } = null!;
    public DbSet<Phone> Phones { get; set; } = null!;

    public UserProfileDbContext(DbContextOptions<UserProfileDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.HasDefaultSchema("profile");
        builder.HasPostgresEnum<AddressType>();
        builder.ApplyConfiguration(new UserProfileConfiguration());
        builder.ApplyConfiguration(new AddressConfiguration());
        builder.ApplyConfiguration(new PhoneConfiguration());
    }
}
