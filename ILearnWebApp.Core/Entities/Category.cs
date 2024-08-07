namespace ILearnWebApp.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; } = null!;
        public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
