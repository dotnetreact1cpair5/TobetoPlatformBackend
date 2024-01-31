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
    public class LessonMappingProfile : Profile
    {
        public LessonMappingProfile()
        {
            CreateMap<CreateLessonRequest, Lesson>().ReverseMap();
            CreateMap<UpdateLessonRequest, Lesson>().ReverseMap();
            CreateMap<DeleteLessonRequest, Lesson>().ReverseMap();

            CreateMap<Lesson, GetListLessonResponse>().ReverseMap();
            CreateMap<Paginate<Lesson>, Paginate<GetListLessonResponse>>().ReverseMap();

            CreateMap<Lesson, CreatedLessonResponse>().ReverseMap();
            CreateMap<Lesson, UpdatedLessonResponse>().ReverseMap();
            CreateMap<Lesson, DeletedLessonResponse>().ReverseMap();
        }
    }
}
