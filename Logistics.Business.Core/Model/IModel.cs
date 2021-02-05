using System;
namespace Logistics.Business.Core.Model
{
    public interface IModel
    {
        Guid Id { get; set; }
        DateTimeOffset CreatedDate { get; set; }
        DateTimeOffset? ModifiedDate { get; set; }
        bool IsDeleted { get; set; }
    }
}
