using System.ComponentModel.DataAnnotations;

namespace ILearnWebApp.Domain.Entities
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            Id = Guid.NewGuid().ToString("N");
            CreatedTime = LastUpdatedTime = DateTime.Now;
        }
        [Key]
        public string? Id { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? LastUpdatedTime { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? DeletedTime { get; set; }
        public string? DeletedBy { get; set; }
    }
}
