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
    public class CourseTimeSpentMappingProfile : Profile
    {
        public CourseTimeSpentMappingProfile()
        {
            CreateMap<CreateCourseTimeSpentRequest, CourseTimeSpent>().ReverseMap();
            CreateMap<UpdateCourseTimeSpentRequest, CourseTimeSpent>().ReverseMap();
            CreateMap<DeleteCourseTimeSpentRequest, CourseTimeSpent>().ReverseMap();

            CreateMap<CourseTimeSpent, GetListCourseTimeSpentResponse>().ReverseMap();
            CreateMap<Paginate<CourseTimeSpent>, Paginate<GetListCourseTimeSpentResponse>>().ReverseMap();

            CreateMap<CourseTimeSpent, CreatedCourseTimeSpentResponse>().ReverseMap();
            CreateMap<CourseTimeSpent, UpdatedCourseTimeSpentResponse>().ReverseMap();
            CreateMap<CourseTimeSpent, DeletedCourseTimeSpentResponse>().ReverseMap();
        }
    }

}
