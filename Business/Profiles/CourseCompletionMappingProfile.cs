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
    public class CourseCompletionMappingProfile : Profile
    {
        public CourseCompletionMappingProfile()
        {
            CreateMap<CreateCourseCompletionRequest, CourseCompletion>().ReverseMap();
            CreateMap<UpdateCourseCompletionRequest, CourseCompletion>().ReverseMap();
            CreateMap<DeleteCourseCompletionRequest, CourseCompletion>().ReverseMap();

            CreateMap<CourseCompletion, GetListCourseCompletionResponse>()
              .ForMember(dest => dest.AccountId, opt => opt.MapFrom(src => src.AccountId))
                .ForMember(dest => dest.CourseName, opt => opt.MapFrom(src => src.Course.Name))
                .ReverseMap();
            CreateMap<Paginate<CourseCompletion>, Paginate<GetListCourseCompletionResponse>>().ReverseMap();

            CreateMap<CourseCompletion, CreatedCourseCompletionResponse>().ReverseMap();
            CreateMap<CourseCompletion, UpdatedCourseCompletionResponse>().ReverseMap();
            CreateMap<CourseCompletion, DeletedCourseCompletionResponse>().ReverseMap();
        }
    }

}
