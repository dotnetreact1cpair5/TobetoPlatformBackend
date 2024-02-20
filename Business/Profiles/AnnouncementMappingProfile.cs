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
    public class AnnouncementMappingProfile : Profile
    {
        public AnnouncementMappingProfile()
        {
            CreateMap<CreateAnnouncementRequest, Announcement>().ReverseMap();
            CreateMap<UpdateAnnouncementRequest, Announcement>().ReverseMap();
            CreateMap<DeleteAnnouncementRequest, Announcement>().ReverseMap();

            CreateMap<Announcement, GetListAnnouncementResponse>()
                .ForMember(dest=>dest.AnnouncementTypeName,opt=>opt.MapFrom(src=>src.AnnouncementType.Name))
                .ForMember(dest => dest.OrganizationName, opt => opt.MapFrom(src => src.Organization.Name))
                .ReverseMap();
            CreateMap<Paginate<Announcement>, Paginate<GetListAnnouncementResponse>>().ReverseMap();
            CreateMap<CreatedAnnouncementResponse, Announcement>().ReverseMap();

            CreateMap<Announcement, UpdatedAnnouncementResponse>().ReverseMap();
            CreateMap<Announcement, DeletedAnnouncementResponse>().ReverseMap();
        }
    }
}
