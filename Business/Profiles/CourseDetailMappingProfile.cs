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
    public class CourseDetailMappingProfile : Profile
    {
        public CourseDetailMappingProfile()
        {
            CreateMap<CreateCourseDetailRequest, CourseTimeSpent>().ReverseMap();
            CreateMap<UpdateCourseDetailRequest, CourseTimeSpent>().ReverseMap();
            CreateMap<DeleteCourseDetailRequest, CourseTimeSpent>().ReverseMap();

            CreateMap<CourseTimeSpent, GetListCourseDetailResponse>().ReverseMap();
            CreateMap<Paginate<CourseTimeSpent>, Paginate<GetListCourseDetailResponse>>().ReverseMap();

            CreateMap<CourseTimeSpent, CreatedCourseDetailResponse>().ReverseMap();
            CreateMap<CourseTimeSpent, UpdatedCourseDetailResponse>().ReverseMap();
            CreateMap<CourseTimeSpent, DeletedCourseDetailResponse>().ReverseMap();
        }
    }
}
