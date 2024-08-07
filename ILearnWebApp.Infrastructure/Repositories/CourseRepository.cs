using ILearnWebApp.Domain.Interfaces.IRepositories;
using ILearnWebApp.Domain.Entities;
using ILearnWebApp.Infrastructure.Data;

namespace ILearnWebApp.Infrastructure.Repositories
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(ILearnDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}
