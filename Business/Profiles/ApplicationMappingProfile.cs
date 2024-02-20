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
    public class ApplicationMappingProfile:Profile
    {
        public ApplicationMappingProfile()
        {
            CreateMap<CreateApplicationRequest, Application>().ReverseMap();
            CreateMap<UpdateApplicationRequest, Application>().ReverseMap();
            CreateMap<DeleteApplicationRequest, Application>().ReverseMap();

            CreateMap<Application, CreatedApplicationResponse>().ReverseMap();
            CreateMap<Application, UpdatedApplicationResponse>().ReverseMap();
            CreateMap<Application, DeletedApplicationResponse>().ReverseMap();

            CreateMap<Application, GetListApplicationResponse>()
                .ForMember(dest=>dest.ApplicationStepName,opt=>opt.MapFrom(src=>src.ApplicationStep.Name))
                .ForMember(dest=>dest.OrganizationName,opt=>opt.MapFrom(src=>src.Organization.Name))
                .ReverseMap();
            CreateMap<Paginate<Application>, Paginate<GetListApplicationResponse>>().ReverseMap();
        }
    }
}
