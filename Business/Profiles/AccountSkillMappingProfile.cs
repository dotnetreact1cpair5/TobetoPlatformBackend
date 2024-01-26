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
    public class AccountSkillMappingProfile:Profile
    {
        public AccountSkillMappingProfile()
        {
            CreateMap<CreateAccountSkillRequest, AccountSkill>().ReverseMap();
            CreateMap<UpdateAccountSkillRequest, AccountSkill>().ReverseMap();
            CreateMap<DeleteAccountSkillRequest, AccountSkill>().ReverseMap();

            CreateMap<AccountSkill, GetListAccountSkillResponse>().ReverseMap();
            CreateMap<Paginate<AccountSkill>, Paginate<GetListAccountSkillResponse>>().ReverseMap();
            CreateMap<CreatedAccountSkillResponse, AccountSkill>().ReverseMap();

            CreateMap<AccountSkill, UpdatedAccountSkillResponse>().ReverseMap();
            CreateMap<AccountSkill, DeletedAccountSkillResponse>().ReverseMap();
        }
    }
}
