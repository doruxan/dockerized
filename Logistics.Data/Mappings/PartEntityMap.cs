using System;
using Logistics.Data.Core;
using Logistics.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Logistics.Data.Mappings
{
    public class PartEntityMap: LogisticsBaseEntityMap<PartEntity>
    {
        public override void ConfigureProps(EntityTypeBuilder<PartEntity> builder)
        {
            builder.Property(x => x.PartNumber).IsRequired();
            builder.Property(x => x.PartWeight).IsRequired();
            builder.Property(x => x.PartCost).IsRequired();

            //builder.HasData(
            //    new PartEntity
            //    {
            //        Id = Guid.NewGuid(),
            //        CreatedDate = DateTimeOffset.UtcNow,
            //        PartNumber = 1,
            //        PartWeight = 1,
            //        PartCost = 50 + 1*7
            //    },
            //    new PartEntity
            //    {
            //        Id = Guid.NewGuid(),
            //        CreatedDate = DateTimeOffset.UtcNow,
            //        PartNumber = 2,
            //        PartWeight = 2,
            //        PartCost = 50 + 2 * 7
            //    },
            //    new PartEntity
            //    {
            //        Id = Guid.NewGuid(),
            //        CreatedDate = DateTimeOffset.UtcNow,
            //        PartNumber = 3,
            //        PartWeight = 3,
            //        PartCost = 50 + 3 * 7
            //    },
            //    new PartEntity
            //    {
            //        Id = Guid.NewGuid(),
            //        CreatedDate = DateTimeOffset.UtcNow,
            //        PartNumber = 4,
            //        PartWeight = 4,
            //        PartCost = 50 + 4 * 7
            //    },
            //    new PartEntity
            //    {
            //        Id = Guid.NewGuid(),
            //        CreatedDate = DateTimeOffset.UtcNow,
            //        PartNumber = 5,
            //        PartWeight = 5,
            //        PartCost = 50 + 5 * 7
            //    });
        }
    }
}
