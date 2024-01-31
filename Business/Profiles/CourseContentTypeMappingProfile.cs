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
    public class CourseContentTypeMappingProfile:Profile
    {
        public CourseContentTypeMappingProfile()
        {
            CreateMap<CreateCourseContentTypeRequest, ContentType>().ReverseMap();
            CreateMap<UpdateCourseContentTypeRequest, ContentType>().ReverseMap();
            CreateMap<DeleteCourseContentTypeRequest, ContentType>().ReverseMap();

            CreateMap<ContentType, GetListCourseContentTypeResponse>().ReverseMap();
            CreateMap<Paginate<ContentType>, Paginate<GetListCourseContentTypeResponse>>().ReverseMap();

            CreateMap<ContentType, CreatedCourseContentTypeResponse>().ReverseMap();
            CreateMap<ContentType, UpdatedCourseContentTypeResponse>().ReverseMap();
            CreateMap<ContentType, DeletedCourseContentTypeResponse>().ReverseMap();
        }
    }
}
