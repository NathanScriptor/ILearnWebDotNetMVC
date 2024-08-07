using ILearnWebApp.Domain.Entities;
using ILearnWebApp.Domain.Interfaces.IRepositories;
using ILearnWebApp.Infrastructure.Data;

namespace ILearnWebApp.Infrastructure.Repositories
{
    public class LecturerRepository : Repository<Lecturer>, ILecturerRepository
    {
        public LecturerRepository(ILearnDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}
