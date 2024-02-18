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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class CourseCompletionMappingProfile : Profile
    {
        public CourseCompletionMappingProfile()
        {
            CreateMap<CreateCourseCompletionRequest, CourseCompletion>().ReverseMap();
            CreateMap<UpdateCourseCompletionRequest, CourseCompletion>().ReverseMap();
            CreateMap<DeleteCourseCompletionRequest, CourseCompletion>().ReverseMap();

            CreateMap<CourseCompletion, GetListCourseCompletionResponse>()
              .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.CourseName, opt => opt.MapFrom(src => src.Course.Name))
                .ReverseMap();
            CreateMap<Paginate<CourseCompletion>, Paginate<GetListCourseCompletionResponse>>().ReverseMap();

            CreateMap<CourseCompletion, CreatedCourseCompletionResponse>().ReverseMap();
            CreateMap<CourseCompletion, UpdatedCourseCompletionResponse>().ReverseMap();
            CreateMap<CourseCompletion, DeletedCourseCompletionResponse>().ReverseMap();
        }
    }

}
