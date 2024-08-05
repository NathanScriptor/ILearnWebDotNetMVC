using ILearnWebApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILearnWebApp.Core.Entities
{
    public class Video : BaseEntity
    { 
        public string Title { get; set; }
        public string Link { get; set; }
        public string CourseId { get; set; }
        public string? Subtitle { get; set; }
        public virtual Course Course { get; set; }
    }
}
