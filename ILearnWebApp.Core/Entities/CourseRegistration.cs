namespace ILearnWebApp.Domain.Entities
{
    public class CourseRegistration
    {
        public string CourseId { get; set; }
        public string StudentId { get; set; }
        public DateTime? CreatedTime { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? LastUpdatedTime { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? DeletedTime { get; set; }
        public string? DeletedBy { get; set; }
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
