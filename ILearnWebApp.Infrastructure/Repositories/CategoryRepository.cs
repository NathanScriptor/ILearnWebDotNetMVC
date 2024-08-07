using ILearnWebApp.Domain.Interfaces.IRepositories;
using ILearnWebApp.Domain.Entities;
using ILearnWebApp.Infrastructure.Data;

namespace ILearnWebApp.Infrastructure.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(ILearnDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}
