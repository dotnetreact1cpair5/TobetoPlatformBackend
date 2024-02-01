﻿using AutoMapper;
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
    public class CoursePageLessonMappingProfile : Profile
    {
        public CoursePageLessonMappingProfile()
        {
            CreateMap<CreateCoursePageLessonRequest, CoursePageLesson>().ReverseMap();
            CreateMap<UpdateCoursePageLessonRequest, CoursePageLesson>().ReverseMap();
            CreateMap<DeleteCoursePageLessonRequest, CoursePageLesson>().ReverseMap();

            CreateMap<CoursePageLesson, GetListCoursePageLessonResponse>()
                .ForMember(dest=>dest.CoursePageName,opt=>opt.MapFrom(src=>src.CoursePage.Name))
                .ForMember(dest=>dest.LessonName,opt=>opt.MapFrom(src=>src.Lesson.Name))
                .ReverseMap();
            CreateMap<Paginate<CoursePageLesson>, Paginate<GetListCoursePageLessonResponse>>().ReverseMap();

            CreateMap<CoursePageLesson, CreatedCoursePageLessonResponse>().ReverseMap();
            CreateMap<CoursePageLesson, UpdatedCoursePageLessonResponse>().ReverseMap();
            CreateMap<CoursePageLesson, DeletedCoursePageLessonResponse>().ReverseMap();
        }
    }
}