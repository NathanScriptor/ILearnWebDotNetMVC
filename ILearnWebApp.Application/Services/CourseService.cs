using ILearnWebApp.Application.IServices;
using ILearnWebApp.Domain.Interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILearnWebApp.Application.Services
{
    public class CourseService(IUnitOfWork unitOfWork) : ICourseService
    {
        private readonly IUnitOfWork _unitOfWork = unitOfWork;
    }
}
