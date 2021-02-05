using System;
namespace Logistics.Business.Core.Model
{
    public class LogisticsModel : IModel
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset? ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
