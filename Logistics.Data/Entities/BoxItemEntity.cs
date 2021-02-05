using System;
using Logistics.Data.Core;

namespace Logistics.Data.Entities
{
    public class BoxItemEntity : LogisticsBaseEntity
    {
        public long BoxId { get; set; }
        public long PartNumber { get; set; }
        public double PartWeight { get; set; }
        public double PartCost { get; set; }
    }
}
