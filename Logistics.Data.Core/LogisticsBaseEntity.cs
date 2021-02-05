using System;
namespace Logistics.Data.Core
{
    public class LogisticsBaseEntity : IEntity
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset? ModifiedDate { get; set; }
        public bool IsDeleted { get ; set; }
    }
}
