using AutoMapper;
using Business.Dtos.Request.CreateRequest;
using Business.Dtos.Request.DeleteRequest;
using Business.Dtos.Request.UpdateRequest;
using Business.Dtos.Response.CreatedResponse;
using Business.Dtos.Response.DeletedResponse;
using Business.Dtos.Response.GetListResponse;
using Business.Dtos.Response.UpdatedResponse;
using Core.DataAccess.Paging;
using Entities.Concretes;
using Microsoft.AspNetCore.Routing.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class CoursePageMappingProfile : Profile
    {
        public CoursePageMappingProfile()
        {
            CreateMap<CreateCoursePageRequest, CoursePage>().ReverseMap();
            CreateMap<UpdateCoursePageRequest, CoursePage>().ReverseMap();
            CreateMap<DeleteCoursePageRequest, CoursePage>().ReverseMap();

            CreateMap<CoursePage, GetListCoursePageResponse>()
               .ForMember(dest=>dest.CourseName,opt=>opt.MapFrom(src=>src.CourseCoursePages))
                .ReverseMap();
            CreateMap<Paginate<CoursePage>, Paginate<GetListCoursePageResponse>>().ReverseMap();

            CreateMap<CoursePage, CreatedCoursePageResponse>().ReverseMap();
            CreateMap<CoursePage, UpdatedCoursePageResponse>().ReverseMap();
            CreateMap<CoursePage, DeletedCoursePageResponse>().ReverseMap();
        }
    }
}
