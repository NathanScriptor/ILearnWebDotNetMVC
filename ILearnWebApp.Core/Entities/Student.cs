using ILearnWebApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILearnWebApp.Core.Entities
{
    public class Student : BaseEntity
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string? Image { get; set; }

        public string AccountId { get; set; }

        public virtual Account Account { get; set; }
    }
}
