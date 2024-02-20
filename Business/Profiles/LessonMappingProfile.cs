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
    public class LessonMappingProfile : Profile
    {
        public LessonMappingProfile()
        {
            CreateMap<CreateLessonRequest, Lesson>().ReverseMap();
            CreateMap<UpdateLessonRequest, Lesson>().ReverseMap();
            CreateMap<DeleteLessonRequest, Lesson>().ReverseMap();

            CreateMap<Lesson, GetListLessonResponse>()
                 .ForMember(dest => dest.CourseName, opt => opt.MapFrom(src => src.Course.Name))
                .ForMember(dest => dest.ContentName, opt => opt.MapFrom(src => src.Content.Name))
                .ForMember(dest => dest.ContentTypeName, opt => opt.MapFrom(src => src.ContentType.Name))
                .ForMember(dest => dest.OrganizationName, opt => opt.MapFrom(src => src.Organization.Name))
                 .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name))
                .ForMember(dest => dest.SessionRecordName, opt => opt.MapFrom(src => src.SessionRecord.Name))
                .ForMember(dest => dest.InstructorName, opt => opt.MapFrom(src => src.Instructor.FirstName +" "+ src.Instructor.LastName))
                .ForMember(dest => dest.PathFileUrl, opt => opt.MapFrom(src => src.PathFile.FileUrl))
                .ReverseMap();
            CreateMap<Paginate<Lesson>, Paginate<GetListLessonResponse>>().ReverseMap();

            CreateMap<Lesson, CreatedLessonResponse>().ReverseMap();
            CreateMap<Lesson, UpdatedLessonResponse>().ReverseMap();
            CreateMap<Lesson, DeletedLessonResponse>().ReverseMap();
        }
    }
}
