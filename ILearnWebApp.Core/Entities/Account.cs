using ILearnWebApp.Core.Entities;

namespace ILearnWebApp.Web.Models
{
    public class Account : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public virtual ICollection<Lecturer> Lecturers { get; set; } = new List<Lecturer>();
        public virtual ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
