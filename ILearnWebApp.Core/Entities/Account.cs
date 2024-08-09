using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ILearnWebApp.Domain.Entities
{
    // Add profile data for application Accounts by adding properties to the Account class
    public class Account : BaseEntity
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Role {  get; set; }
        public virtual ICollection<Lecturer> Lecturers { get; set; } = new List<Lecturer>();
        public virtual ICollection<Student> Students { get; set; } = new List<Student>();
    }
}

