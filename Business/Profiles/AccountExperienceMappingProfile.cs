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
    public class AccountExperienceMappingProfile : Profile
    {
        public AccountExperienceMappingProfile()
        {
            CreateMap<CreateAccountExperienceRequest, AccountExperience>().ReverseMap();
            CreateMap<AccountExperience, CreatedAccountExperienceResponse>().ReverseMap();

            CreateMap<DeleteAccountExperienceRequest, AccountExperience>().ReverseMap();
            CreateMap<AccountExperience, DeletedAccountExperienceResponse>().ReverseMap();
            
            CreateMap<Paginate<AccountExperience>, Paginate<GetListAccountExperienceResponse>>().ReverseMap();
            CreateMap<AccountExperience, GetListAccountExperienceResponse>().ReverseMap();
            
            CreateMap<UpdateAccountExperienceRequest, AccountExperience>().ReverseMap();
            CreateMap<AccountExperience, UpdatedAccountExperienceResponse>().ReverseMap();
        }
    }
}
