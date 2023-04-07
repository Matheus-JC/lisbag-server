using LisbagServer.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LisbagServer.Infra.Dal.EntitiesConfiguration;

public class BaseEntityConfiguration : IEntityTypeConfiguration<BaseEntity>
{
    public void Configure(EntityTypeBuilder<BaseEntity> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.CreatedDate).HasDefaultValue(DateTime.UtcNow);
        builder.Property(x => x.LastModified).HasDefaultValue(DateTime.UtcNow);

        //builder.Property<DateTime>("CreatedDate").HasDefaultValue(DateTime.UtcNow);
        //builder.Property<DateTime>("LastModified").HasDefaultValue(DateTime.UtcNow);
    }
}
