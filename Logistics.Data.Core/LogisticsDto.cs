using System;
namespace Logistics.Data.Core
{
    public class LogisticsDto: IDto
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset? ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
