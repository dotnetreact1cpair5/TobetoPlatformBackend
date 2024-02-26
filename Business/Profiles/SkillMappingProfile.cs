using AutoMapper;
using Business.Dtos.Request.CreateRequest;
using Business.Dtos.Request.DeleteRequest;
using Business.Dtos.Request.UpdateRequest;
using Business.Dtos.Response;
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
    public class SkillMappingProfile : Profile
        {
            public SkillMappingProfile()
            {
                CreateMap<CreateSkillRequest, Skill>().ReverseMap();
                CreateMap<UpdateSkillRequest, Skill>().ReverseMap();
                CreateMap<DeleteSkillsRequest, Skill>().ReverseMap();

                CreateMap<Skill, GetListSkillsResponse>().ReverseMap();
                CreateMap<Paginate<Skill>, Paginate<GetListSkillsResponse>>().ReverseMap();
                CreateMap<CreatedSkillsResponse, Skill>().ReverseMap();

                CreateMap<Skill, UpdatedSkillResponse>().ReverseMap();
                CreateMap<Skill, DeletedSkillsResponse>().ReverseMap();
            }
        }
    
}
