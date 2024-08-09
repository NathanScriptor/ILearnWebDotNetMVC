using System.Runtime.InteropServices;

namespace ILearnWebApp.Domain.Entities
{
    public class Discount : BaseEntity
    {
        public int Percent {  get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Status { get; set; }
        public string CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
