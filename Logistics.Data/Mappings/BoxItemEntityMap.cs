using System;
using Logistics.Data.Core;
using Logistics.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Logistics.Data.Mappings
{
    public class BoxItemEntityMap : LogisticsBaseEntityMap<BoxItemEntity>
    {
        public override void ConfigureProps(EntityTypeBuilder<BoxItemEntity> builder)
        {
            builder.Property(x => x.BoxId).IsRequired();
            builder.Property(x => x.PartNumber).IsRequired();
            builder.Property(x => x.PartWeight).IsRequired();
            builder.Property(x => x.PartCost).IsRequired();
        }
    }
}
