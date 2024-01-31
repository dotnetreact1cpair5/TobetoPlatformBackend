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
    public class ClassLessonMappingProfile : Profile
    {
        public ClassLessonMappingProfile()
        {
            CreateMap<CreateClassLessonRequest, ClassCourse>().ReverseMap();
            CreateMap<UpdateClassLessonRequest, ClassCourse>().ReverseMap();
            CreateMap<DeleteClassLessonRequest, ClassCourse>().ReverseMap();

            CreateMap<ClassCourse, GetListClassLessonResponse>().ReverseMap();
            CreateMap<Paginate<ClassCourse>, Paginate<GetListClassLessonResponse>>().ReverseMap();

            CreateMap<ClassCourse, CreatedClassLessonResponse>().ReverseMap();
            CreateMap<ClassCourse, UpdatedClassLessonResponse>().ReverseMap();
            CreateMap<ClassCourse, DeletedClassLessonResponse>().ReverseMap();
        }
    }
}
