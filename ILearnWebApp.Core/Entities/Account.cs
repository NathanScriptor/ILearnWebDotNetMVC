using Microsoft.AspNetCore.Identity;

namespace ILearnWebApp.Domain.Entities
{
    // Add profile data for application Accounts by adding properties to the Account class
    public class Account : IdentityUser
    {
        public string Role { get; set; }
        public string Image {  get; set; } 
        public virtual ICollection<Lecturer> Lecturers { get; set; } = new List<Lecturer>();
        public virtual ICollection<Student> Students { get; set; } = new List<Student>();
    }
}

