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
    public class ContentCoursePageMappingProfile : Profile
    {
        public ContentCoursePageMappingProfile()
        {
            CreateMap<CreateContentCoursePageRequest, ContentCoursePage>().ReverseMap();
            CreateMap<UpdateContentCoursePageRequest, ContentCoursePage>().ReverseMap();
            CreateMap<DeleteContentCoursePageRequest, ContentCoursePage>().ReverseMap();

            CreateMap<ContentCoursePage, GetListContentCoursePageResponse>()
                .ForMember(destinationMember: a => a.ContentName,
memberOptions: opt => opt.MapFrom(a => a.Content.Name)).
              ReverseMap();
            CreateMap<Paginate<ContentCoursePage>, Paginate<GetListContentCoursePageResponse>>().ReverseMap();

            CreateMap<ContentCoursePage, CreatedContentCoursePageResponse>().ReverseMap();
            CreateMap<ContentCoursePage, UpdatedContentCoursePageResponse>().ReverseMap();
            CreateMap<ContentCoursePage, DeletedContentCoursePageResponse>().ReverseMap();
        }
    }

}