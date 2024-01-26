﻿using AutoMapper;
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
        public class SkillMappingProfile : Profile
        {
            public SkillMappingProfile()
            {
                CreateMap<CreateSkillRequest, Skill>().ReverseMap();
                CreateMap<UpdateSkillRequest, Skill>().ReverseMap();
                CreateMap<DeleteSkillRequest, Skill>().ReverseMap();

                CreateMap<Skill, GetListSkillResponse>().ReverseMap();
                CreateMap<Paginate<Skill>, Paginate<GetListSkillResponse>>().ReverseMap();

                CreateMap<CreatedSkillResponse, Skill>().ReverseMap();
                CreateMap<UpdatedSkillResponse, Skill>().ReverseMap();
                CreateMap<DeletedSkillResponse, Skill>().ReverseMap();
            }
        }
    
}