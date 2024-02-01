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
    public class ContentMappingProfile : Profile
    {
        public ContentMappingProfile()
        {
            CreateMap<CreateContentRequest, Content>().ReverseMap();
            CreateMap<UpdateContentRequest, Content>().ReverseMap();
            CreateMap<DeleteContentRequest, Content>().ReverseMap();

            CreateMap<Content, GetListContentResponse>().ReverseMap();
            CreateMap<Paginate<Content>, Paginate<GetListContentResponse>>().ReverseMap();

            CreateMap<Content, CreatedContentResponse>().ReverseMap();
            CreateMap<Content, UpdatedContentResponse>().ReverseMap();
            CreateMap<Content, DeletedContentResponse>().ReverseMap();
        }
    }
}
