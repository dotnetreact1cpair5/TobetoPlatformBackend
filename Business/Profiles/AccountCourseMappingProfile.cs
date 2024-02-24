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
    public class AccountCourseMappingProfile : Profile
    {
        public AccountCourseMappingProfile()
        {
            CreateMap<CreateAccountCourseRequest, AccountCourse>().ReverseMap();
            CreateMap<UpdateAccountCourseRequest, AccountCourse>().ReverseMap();
            CreateMap<DeleteAccountCourseRequest, AccountCourse>().ReverseMap();

            CreateMap<AccountCourse, GetListAccountCourseResponse>()
                .ForMember(dest=>dest.UserId,opt=>opt.MapFrom(src=>src.User.Id))
                .ForMember(dest => dest.CourseName, opt => opt.MapFrom(src => src.Lesson.Course.Name))
                .ForMember(dest => dest.ContentName, opt => opt.MapFrom(src => src.Lesson.Content.Name))
                .ForMember(dest => dest.LessonName, opt => opt.MapFrom(src => src.Lesson.Name))
                .ForMember(dest => dest.SessionRecord, opt => opt.MapFrom(src => src.Lesson.SessionRecord.Name))
                .ForMember(dest => dest.Instructor, opt => opt.MapFrom(src => src.Lesson.Instructor.FirstName +" "+ src.Lesson.Instructor.LastName))
                .ForMember(dest => dest.CategoryLesson, opt => opt.MapFrom(src => src.Lesson.Category.Name))
                .ForMember(dest => dest.CategoryCourse, opt => opt.MapFrom(src => src.Lesson.Course.Category.Name))
                .ForMember(dest => dest.OrganizationName, opt => opt.MapFrom(src => src.Lesson.Course.Organization.Name))
                .ForMember(dest => dest.ContentTypeCourse, opt => opt.MapFrom(src => src.Lesson.Course.ContentType.Name))
                .ForMember(dest => dest.ContentTypeLesson, opt => opt.MapFrom(src => src.Lesson.ContentType.Name))
                .ForMember(dest => dest.PathFileCourse, opt => opt.MapFrom(src => src.Lesson.Course.PathFile.FileUrl))
                .ForMember(dest => dest.PathFileLesson, opt => opt.MapFrom(src => src.Lesson.PathFile.FileUrl))
                .ForMember(dest => dest.LessonVideoDuration, opt => opt.MapFrom(src => src.Lesson.VideoDuration))
                 .ForMember(dest => dest.EstimatedVideoDuration, opt => opt.MapFrom(src => src.Lesson.Course.EstimatedVideoDuration))
                .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.Lesson.Course.StartDate))
                .ForMember(dest => dest.EndDate, opt => opt.MapFrom(src => src.Lesson.Course.EndDate))
             .ReverseMap();
            CreateMap<List<AccountCourse>, Paginate<GetListAccountCourseResponse>>().ForMember(destinationMember:a=>a.Items,memberOptions:c=>c.MapFrom(ac=>ac.ToList())).ReverseMap();

           
            CreateMap<Paginate<AccountCourse>, Paginate<GetListAccountCourseResponse>>().ReverseMap();

            CreateMap<AccountCourse, CreatedAccountCourseResponse>().ReverseMap();
            CreateMap<AccountCourse, UpdatedAccountCourseResponse>().ReverseMap();
            CreateMap<AccountCourse, DeletedAccountCourseResponse>().ReverseMap();
        }
    }
}
