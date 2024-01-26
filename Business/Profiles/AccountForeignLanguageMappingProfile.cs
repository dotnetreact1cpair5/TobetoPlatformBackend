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
    public class AccountForeignLanguageMappingProfile:Profile
    {
        public AccountForeignLanguageMappingProfile()
        {
            CreateMap<CreateAccountForeignLanguageRequest, AccountForeignLanguage>().ReverseMap();
            CreateMap<UpdateAccountForeignLanguageRequest, AccountForeignLanguage>().ReverseMap();
            CreateMap<DeleteAccountRequest, AccountForeignLanguage>().ReverseMap();

            CreateMap<AccountForeignLanguage, GetListAccountForeignLanguageResponse>().ReverseMap();
            CreateMap<Paginate<AccountForeignLanguage>, Paginate<GetListAccountForeignLanguageResponse>>().ReverseMap();

            CreateMap<AccountForeignLanguage, CreatedAccountForeignLanguageResponse>().ReverseMap();
            CreateMap<AccountForeignLanguage, UpdatedAccountForeignLanguageResponse>().ReverseMap();
            CreateMap<AccountForeignLanguage, DeletedAccountForeignLanguageResponse>().ReverseMap();
        }
    }
}
