using ILearnWebApp.Core.Entities;

namespace ILearnWebApp.Web.Models
{
    public class Course : BaseEntity
    { 
        public string? Name { get; set; }
        public double Price { get; set; }
        public string? Introduction { get; set; }
        public string? Description { get; set; }
        public int? NumberOfLectures { get; set; }
        public decimal? DiscountPrice { get; set; }
        public string? Img { get; set; }
        public string LecturerId { get; set; }
        public string CategoryId { get; set; }
        public string DiscountId { get; set; }
        public virtual Category Category { get; set; }
        public virtual Lecturer Lecturer { get; set; }
        public virtual Discount Discount { get; set; }
        public virtual ICollection<Video> Videos { get; set; } = new List<Video>();
    }
}
