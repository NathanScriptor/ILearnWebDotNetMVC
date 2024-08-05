using ILearnWebApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILearnWebApp.Core.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; } = null!;
        public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
