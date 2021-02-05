using System;
using Logistics.Data.Core;

namespace Logistics.Data.Entities
{
    public class BoxEntity: LogisticsBaseEntity
    {
        public long BoxId { get; set; }
        public double Weight { get; set; }
        public int? PartCount { get; set; }
    }
}
