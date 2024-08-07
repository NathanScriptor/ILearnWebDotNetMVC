using ILearnWebApp.Domain.Entities;
using ILearnWebApp.Domain.Interfaces.IRepositories;
using ILearnWebApp.Infrastructure.Data;

namespace ILearnWebApp.Infrastructure.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(ILearnDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}
