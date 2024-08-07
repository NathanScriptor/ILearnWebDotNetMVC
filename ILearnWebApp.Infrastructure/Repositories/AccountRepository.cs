using ILearnWebApp.Domain.Interfaces.IRepositories;
using ILearnWebApp.Domain.Entities;
using ILearnWebApp.Infrastructure.Data;

namespace ILearnWebApp.Infrastructure.Repositories
{
    public class AccountRepository : Repository<Account>, IAccountRepository
    {
        public AccountRepository(ILearnDbContext dbContext) : base(dbContext) 
        {

        }
    }
}
