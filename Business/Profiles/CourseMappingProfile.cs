using AutoMapper;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class CourseMappingProfile : Profile
    {
        public CourseMappingProfile()
        {
            CreateMap<CreateCourseRequest, Course>().ReverseMap();
            CreateMap<UpdateCourseRequest, Course>().ReverseMap();
            CreateMap<DeleteCourseRequest, Course>().ReverseMap();


            CreateMap<Course, GetListCourseResponse>().ReverseMap();
            CreateMap<Paginate<Course>, Paginate<GetListCourseResponse>>().ReverseMap();

            CreateMap<Course, CreatedCourseResponse>().ReverseMap();
            CreateMap<Course, UpdatedCourseResponse>().ReverseMap();
            CreateMap<Course, DeletedCourseResponse>().ReverseMap();
        }
    }
}
