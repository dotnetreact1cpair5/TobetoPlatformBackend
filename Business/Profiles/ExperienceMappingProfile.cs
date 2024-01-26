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
    public class ExperienceMappingProfile : Profile
    {
        public ExperienceMappingProfile()
        {
            CreateMap<CreateAccountExperienceRequest, AccountExperience>().ReverseMap();
            CreateMap<UpdateAccountExperienceRequest, AccountExperience>().ReverseMap();
            CreateMap<DeleteAccountExperienceRequest, AccountExperience>().ReverseMap();
            CreateMap<Paginate<AccountExperience>, Paginate<GetListAccountExperienceResponse>>().ReverseMap();
            CreateMap<AccountExperience, CreatedAccountExperienceResponse>().ReverseMap();
            CreateMap<AccountExperience, UpdatedAccountExperienceResponse>().ReverseMap();
            CreateMap<AccountExperience, DeletedAccountExperienceResponse>().ReverseMap();
            CreateMap<AccountExperience, GetListAccountExperienceResponse>().ReverseMap();
        }
    }
}
