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
    public class CourseMappingProfile : Profile
    {
        public CourseMappingProfile()
        {
            CreateMap<CreateCourseRequest, Course>().ReverseMap();
            CreateMap<UpdateCourseRequest, Course>().ReverseMap();
            CreateMap<DeleteCourseRequest, Course>().ReverseMap();

            CreateMap<Course, GetListCourseResponse>()
                .ForMember(dest=>dest.ContentTypeName,opt=>opt.MapFrom(src=>src.ContentType.Name))
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name))
                .ForMember(dest => dest.OrganizationName, opt => opt.MapFrom(src => src.Organization.Name))
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.User.Id))
                .ReverseMap();

            CreateMap<Paginate<Course>, Paginate<GetListCourseResponse>>().ReverseMap();

            CreateMap<Course, CreatedCourseResponse>().ReverseMap();
            CreateMap<Course, UpdatedCourseResponse>().ReverseMap();
            CreateMap<Course, DeletedCourseResponse>().ReverseMap();
        }
    }
}
