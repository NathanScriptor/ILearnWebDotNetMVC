using ILearnWebApp.Domain.Entities;
using ILearnWebApp.Domain.Interfaces.IRepositories;
using ILearnWebApp.Domain.Interfaces.UnitOfWork;
using ILearnWebApp.Infrastructure.Data;
using ILearnWebApp.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ILearnWebApp.Infrastructure.Repositories.UnitOfWork
{
    public class UnitOfWork(ILearnDbContext dbContext) : IUnitOfWork
    {
        private readonly ILearnDbContext _dbContext = dbContext;

        public IRepository<T> GetRepository<T>() where T : class
        {
            return new Repository<T>(_dbContext);
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
