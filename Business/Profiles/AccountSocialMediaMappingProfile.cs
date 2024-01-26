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
    public class AccountSocialMediaMappingProfile:Profile
    {
        public AccountSocialMediaMappingProfile()
        {
            CreateMap<CreateAccountSocialMediaRequest, AccountSocialMedia>().ReverseMap();
            CreateMap<UpdateAccountSocialMediaRequest, AccountSocialMedia>().ReverseMap();
            CreateMap<DeleteAccountSocialMediaRequest, AccountSocialMedia>().ReverseMap();

            CreateMap<AccountSocialMedia,CreatedAccountSocialMediaResponse>().ReverseMap();
            CreateMap<AccountSocialMedia, UpdatedAccountSocialMediaResponse>().ReverseMap();
            CreateMap<AccountSocialMedia, DeletedAccountSocialMediaResponse>().ReverseMap();

            CreateMap<AccountSocialMedia, GetListAccountSocialMediaResponse>().ReverseMap();
            CreateMap<Paginate<AccountSocialMedia>, Paginate<GetListAccountSocialMediaResponse>>().ReverseMap();
        }
    }
}
