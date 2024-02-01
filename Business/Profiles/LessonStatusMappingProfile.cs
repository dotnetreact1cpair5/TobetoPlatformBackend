﻿using AutoMapper;
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
    public class LessonStatusMappingProfile : Profile
    {
        public LessonStatusMappingProfile()
        {
            CreateMap<CreateLessonStatusRequest, LessonStatus>().ReverseMap();
            CreateMap<UpdateLessonStatusRequest, LessonStatus>().ReverseMap();
            CreateMap<DeleteLessonStatusRequest, LessonStatus>().ReverseMap();

            CreateMap<LessonStatus, GetListLessonStatusResponse>().ReverseMap();
            CreateMap<Paginate<LessonStatus>, Paginate<GetListLessonStatusResponse>>().ReverseMap();

            CreateMap<LessonStatus, CreatedLessonStatusResponse>().ReverseMap();
            CreateMap<LessonStatus, UpdatedLessonStatusResponse>().ReverseMap();
            CreateMap<LessonStatus, DeletedLessonStatusResponse>().ReverseMap();
        }
    }
}
