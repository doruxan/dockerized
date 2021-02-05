using System;

namespace Logistics.Data.Core
{
    public interface IEntity
    {
        Guid Id { get; set; }
        DateTimeOffset CreatedDate { get; set; }
        DateTimeOffset? ModifiedDate { get; set; }
        bool IsDeleted { get; set; }
    }
}
