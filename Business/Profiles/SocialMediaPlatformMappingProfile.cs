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
    public class SocialMediaPlatformMappingProfile:Profile
    {
        public SocialMediaPlatformMappingProfile()
        {
            CreateMap<CreateSocialMediaPlatformRequest,SocialMediaPlatform>().ReverseMap();
            CreateMap<UpdateSocialMediaPlatformRequest, SocialMediaPlatform>().ReverseMap();
            CreateMap<DeleteSocialMediaPlatformRequest, SocialMediaPlatform>().ReverseMap();

            CreateMap<SocialMediaPlatform, CreatedSocialMediaPlatformResponse>().ReverseMap();
            CreateMap<SocialMediaPlatform, UpdatedSocialMediaPlatformResponse>().ReverseMap();
            CreateMap<SocialMediaPlatform, DeletedSocialMediaPlatformResponse>().ReverseMap();

            CreateMap<SocialMediaPlatform,GetListSocialMediaPlatformResponse>().ReverseMap();
            CreateMap<Paginate<SocialMediaPlatform>,Paginate<GetListSocialMediaPlatformResponse>>().ReverseMap();         
        }
    }
}
