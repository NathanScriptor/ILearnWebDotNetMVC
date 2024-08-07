namespace ILearnWebApp.Domain.Entities
{
    public class CourseRegistration : BaseEntity
    {
        public string CourseId { get; set; }
        public string StudentId { get; set; }
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
