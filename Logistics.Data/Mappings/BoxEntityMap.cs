using System;
using Logistics.Data.Core;
using Logistics.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Logistics.Data.Mappings
{
    public class BoxEntityMap:LogisticsBaseEntityMap<BoxEntity>
    {
        public override void ConfigureProps(EntityTypeBuilder<BoxEntity> builder)
        {
            builder.Property(x => x.BoxId).IsRequired();
            builder.Property(x => x.Weight).IsRequired();
            builder.Property(x => x.PartCount);

            //builder.HasData(
            //    new BoxEntity
            //    {
            //        Id = Guid.NewGuid(),
            //        CreatedDate = DateTimeOffset.UtcNow,
            //        BoxId = 123450,
            //        Weight = 3,
            //    },
            //    new BoxEntity
            //    {
            //        Id = Guid.NewGuid(),
            //        CreatedDate = DateTimeOffset.UtcNow,
            //        BoxId = 123461,
            //        Weight = 8,
            //    },
            //    new BoxEntity
            //    {
            //        Id = Guid.NewGuid(),
            //        CreatedDate = DateTimeOffset.UtcNow,
            //        BoxId = 123472,
            //        Weight = 11,
            //    },
            //    new BoxEntity
            //    {
            //        Id = Guid.NewGuid(),
            //        CreatedDate = DateTimeOffset.UtcNow,
            //        BoxId = 123483,
            //        Weight = 3,
            //    },
            //    new BoxEntity
            //    {
            //        Id = Guid.NewGuid(),
            //        CreatedDate = DateTimeOffset.UtcNow,
            //        BoxId = 123494,
            //        Weight = 13,
            //    });
        }
    }
}
