using System;
namespace Logistics.Data.Core
{
    public interface IDto
    {
        Guid Id { get; set; }
        DateTimeOffset CreatedDate { get; set; }
        DateTimeOffset? ModifiedDate { get; set; }
        bool IsDeleted { get; set; }
    }
}
