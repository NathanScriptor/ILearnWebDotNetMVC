namespace ILearnWebApp.Domain.Entities
{
    public class Course : BaseEntity
    { 
        public string? Name { get; set; }
        public double Price { get; set; }
        public string? Introduction { get; set; }
        public string? Description { get; set; }
        public int? NumberOfLectures { get; set; }
        public string? Image { get; set; }
        public string LecturerId { get; set; }
        public string CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual Lecturer Lecturer { get; set; }
        public virtual ICollection<Video> Videos { get; set; } = new List<Video>();
        public virtual ICollection<CourseRegistration> CourseRegistrations { get; set; } = new List<CourseRegistration>();
    }
}
