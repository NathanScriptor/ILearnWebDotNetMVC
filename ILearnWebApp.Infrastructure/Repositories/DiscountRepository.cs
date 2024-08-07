using ILearnWebApp.Domain.Entities;
using ILearnWebApp.Domain.Interfaces.IRepositories;
using ILearnWebApp.Infrastructure.Data;

namespace ILearnWebApp.Infrastructure.Repositories
{
    public class DiscountRepository : Repository<Discount>, IDiscountRepository
    {
        public DiscountRepository(ILearnDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}
