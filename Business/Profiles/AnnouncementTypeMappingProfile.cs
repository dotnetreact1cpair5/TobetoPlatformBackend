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
    public class AnnouncementTypeMappingProfile : Profile
    {
        public AnnouncementTypeMappingProfile()
        {
            CreateMap<CreateAnnouncementTypeRequest, AnnouncementType>().ReverseMap();
            CreateMap<UpdateAnnouncementTypeRequest, AnnouncementType>().ReverseMap();
            CreateMap<DeleteAnnouncementTypeRequest, AnnouncementType>().ReverseMap();

            CreateMap<AnnouncementType, GetListAnnouncementTypeResponse>().ReverseMap();
            CreateMap<Paginate<AnnouncementType>, Paginate<GetListAnnouncementTypeResponse>>().ReverseMap();

            CreateMap<AnnouncementType, CreatedAnnouncementTypeResponse>().ReverseMap();
            CreateMap<AnnouncementType, UpdatedAnnouncementTypeResponse>().ReverseMap();
            CreateMap<AnnouncementType, DeletedAnnouncementTypeResponse>().ReverseMap();
        }
    }

}
