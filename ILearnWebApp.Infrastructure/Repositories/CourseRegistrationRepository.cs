using ILearnWebApp.Domain.Entities;
using ILearnWebApp.Domain.Interfaces.IRepositories;
using ILearnWebApp.Infrastructure.Data;

namespace ILearnWebApp.Infrastructure.Repositories
{
    public class CourseRegistrationRepository : Repository<CourseRegistration>, ICourseRegistationRepository
    {
        public CourseRegistrationRepository(ILearnDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}
