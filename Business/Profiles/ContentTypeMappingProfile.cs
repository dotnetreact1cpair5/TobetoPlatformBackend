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
    public class ContentTypeMappingProfile:Profile
    {
        public ContentTypeMappingProfile()
        {
            CreateMap<CreateContentTypeRequest, ContentType>().ReverseMap();
            CreateMap<UpdateContentTypeRequest, ContentType>().ReverseMap();
            CreateMap<DeleteContentTypeRequest, ContentType>().ReverseMap();

            CreateMap<ContentType, GetListContentTypeResponse>().ReverseMap();
            CreateMap<Paginate<ContentType>, Paginate<GetListContentTypeResponse>>().ReverseMap();

            CreateMap<ContentType, CreatedContentTypeResponse>().ReverseMap();
            CreateMap<ContentType, UpdatedContentTypeResponse>().ReverseMap();
            CreateMap<ContentType, DeletedContentTypeResponse>().ReverseMap();
        }
    }
}
