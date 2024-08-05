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
    public class VideoRepository : Repository<Video>, IVideoRepository
    {
        public VideoRepository(ILearnDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}
