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
    public class ForeignLanguageLevelMappingProfile : Profile
    {
       public ForeignLanguageLevelMappingProfile()
        {
            CreateMap<CreateForeignLanguageLevelRequest, ForeignLanguageLevel>().ReverseMap();
            CreateMap<UpdateForeignLanguageLevelRequest, ForeignLanguageLevel>().ReverseMap();
            CreateMap<DeleteForeignLanguageLevelRequest, ForeignLanguageLevel>().ReverseMap();

            CreateMap<ForeignLanguageLevel, GetListForeignLanguageLevelResponse>().ReverseMap();
            CreateMap<Paginate<ForeignLanguageLevel>, Paginate<GetListForeignLanguageLevelResponse>>().ReverseMap();

            CreateMap<ForeignLanguageLevel, CreatedForeignLanguageLevelResponse>().ReverseMap();
            CreateMap<ForeignLanguageLevel, UpdatedForeignLanguageLevelResponse>().ReverseMap();
            CreateMap<ForeignLanguageLevel, DeletedForeignLanguageLevelResponse>().ReverseMap();
        }
    }
}
