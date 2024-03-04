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
    public class LessonStatuMappingProfile : Profile
    {
        public LessonStatuMappingProfile()
        {
            CreateMap<CreateLessonStatuRequest, LessonStatu>().ReverseMap();
            CreateMap<UpdateLessonStatuRequest, LessonStatu>().ReverseMap();
            CreateMap<DeleteLessonStatuRequest, LessonStatu>().ReverseMap();

            CreateMap<LessonStatu, GetListLessonStatuResponse>().ReverseMap();
            CreateMap<Paginate<LessonStatu>, Paginate<GetListLessonStatuResponse>>().ReverseMap();

            CreateMap<LessonStatu, CreatedLessonStatuResponse>().ReverseMap();
            CreateMap<LessonStatu, UpdatedLessonStatuResponse>().ReverseMap();
            CreateMap<LessonStatu, DeletedLessonStatuResponse>().ReverseMap();
        }
    }
}
