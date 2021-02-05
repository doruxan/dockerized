
using System;
using Logistics.Data.Core;

namespace Logistics.Data.Entities
{
    public class PartEntity : LogisticsBaseEntity
    {
        public long PartNumber { get; set; }
        public int PartWeight { get; set; }
        public double PartCost { get; set; }
    }
}
