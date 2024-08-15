using ILearnWebApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILearnWebApp.Domain.DTOs.Course
{
    public class GetCourseModel
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Introduction { get; set; }
        public string Description { get; set; }
        public int? NumberOfLectures { get; set; }
        public string? Image { get; set; }
        public string LecturerId { get; set; }
        public string CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
