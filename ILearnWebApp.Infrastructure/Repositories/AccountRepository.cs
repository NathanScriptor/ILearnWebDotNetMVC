using ILearnWebApp.Core.Interfaces.IRepositories;
using ILearnWebApp.Infrastructure.Data;
using ILearnWebApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILearnWebApp.Infrastructure.Repositories
{
    public class AccountRepository : Repository<Account>, IAccountRepository
    {
        public AccountRepository(ILearnDbContext dbContext) : base(dbContext) 
        {

        }
    }
}
