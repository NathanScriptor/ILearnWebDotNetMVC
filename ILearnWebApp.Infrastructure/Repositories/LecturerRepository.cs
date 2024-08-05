using ILearnWebApp.Core.Entities;
using ILearnWebApp.Core.Interfaces.IRepositories;
using ILearnWebApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILearnWebApp.Infrastructure.Repositories
{
    public class LecturerRepository : Repository<Lecturer>, ILecturerRepository
    {
        public LecturerRepository(ILearnDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}
