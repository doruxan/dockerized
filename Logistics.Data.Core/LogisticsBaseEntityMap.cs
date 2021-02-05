using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Logistics.Data.Core
{
    public abstract class LogisticsBaseEntityMap<TEntity> : IEntityTypeConfiguration<TEntity>
    where TEntity : LogisticsBaseEntity
    {
        public void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.ModifiedDate);
            builder.Property(x => x.IsDeleted);

            ConfigureProps(builder);
        }

        public abstract void ConfigureProps(EntityTypeBuilder<TEntity> builder);
    }
}
