using System;
using Logistics.Data.Core;

namespace Logistics.Data.Dtos
{
    public class BoxDto:LogisticsDto
    {
        public long BoxId { get; set; }
        public double Weight { get; set; }
        public int? PartCount { get; set; }
    }
}
