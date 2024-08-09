namespace ILearnWebApp.Domain.Entities
{
    public class Video : BaseEntity
    { 
        public string Title { get; set; }
        public string Link { get; set; }
        public string CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
