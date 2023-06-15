using LisbagServer.Domain.Entities.UserProfileAggregate;
using LisbagServer.Infra.Dal.EntitiesConfiguration;
using Microsoft.EntityFrameworkCore;

namespace LisbagServer.Infra.Dal.Context;

public sealed class UserProfileDbContext : DbContext
{
    public UserProfileDbContext(DbContextOptions<UserProfileDbContext> options) : base(options)
    { }

    public DbSet<UserProfile> UserProfiles { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Phone> Phones { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.HasDefaultSchema("profile");
        builder.ApplyConfiguration(new UserProfileConfiguration());
        builder.ApplyConfiguration(new AddressConfiguration());
        builder.ApplyConfiguration(new PhoneConfiguration());
    }
}
