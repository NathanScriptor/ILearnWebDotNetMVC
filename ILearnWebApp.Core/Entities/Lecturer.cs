namespace ILearnWebApp.Domain.Entities
{
    public class Lecturer : BaseEntity
    {
        public string Name { get; set; }

        public string? Description { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string? Image { get; set; }

        public string AccountId { get; set; }

        public virtual Account Account { get; set; }

        public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
