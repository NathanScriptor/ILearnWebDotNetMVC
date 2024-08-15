using AutoMapper;
using ILearnWebApp.Domain.DTOs.Course;
using ILearnWebApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILearnWebApp.Application.Mapper
{
    public class CourseProfile : Profile
    {
        public CourseProfile()
        {
            CreateMap<Course, GetCourseModel>().ReverseMap();
        }
    }
}
