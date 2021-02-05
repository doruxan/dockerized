using System;
using Logistics.Data.Core;

namespace Logistics.Data.Dtos
{
    public class PartDto:LogisticsDto
    {
        public long PartNumber { get; set; }
        public int PartWeight { get; set; }
        public double PartCost { get; set; }
    }
}
