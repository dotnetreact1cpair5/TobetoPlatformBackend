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
    public class CourseCoursePageMappingProfile : Profile
    {
        public CourseCoursePageMappingProfile()
        {
            CreateMap<CreateCourseCoursePageRequest, CourseCoursePage>().ReverseMap();
            CreateMap<UpdateCourseCoursePageRequest, CourseCoursePage>().ReverseMap();
            CreateMap<DeleteCourseCoursePageRequest, CourseCoursePage>().ReverseMap();

            CreateMap<CourseCoursePage, GetListCourseCoursePageResponse>()
                .ForMember(dest=>dest.CourseName,opt=>opt.MapFrom(src=>src.Course.Name))
                .ReverseMap();
            CreateMap<Paginate<CourseCoursePage>, Paginate<GetListCourseCoursePageResponse>>().ReverseMap();

            CreateMap<CourseCoursePage, CreatedCourseCoursePageResponse>().ReverseMap();
            CreateMap<CourseCoursePage, UpdatedCourseCoursePageResponse>().ReverseMap();
            CreateMap<CourseCoursePage, DeletedCourseCoursePageResponse>().ReverseMap();
        }
    }

}
