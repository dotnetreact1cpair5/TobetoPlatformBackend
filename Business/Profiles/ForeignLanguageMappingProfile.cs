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
    public class ForeignLanguageMappingProfile:Profile
    {
        public ForeignLanguageMappingProfile()
        {
            CreateMap<CreateForeignLanguageRequest, ForeignLanguage>().ReverseMap();
            CreateMap<UpdateForeignLanguageRequest, ForeignLanguage>().ReverseMap();
            CreateMap<DeleteForeignLanguageRequest, ForeignLanguage>().ReverseMap();

            CreateMap<ForeignLanguage, GetListForeignLanguageResponse>().ReverseMap();
            CreateMap<Paginate<ForeignLanguage>, Paginate<GetListForeignLanguageResponse>>().ReverseMap();

            CreateMap<ForeignLanguage, CreatedForeignLanguageResponse>().ReverseMap();
            CreateMap<ForeignLanguage, UpdatedForeignLanguageResponse>().ReverseMap();
            CreateMap<ForeignLanguage, DeletedForeignLanguageResponse>().ReverseMap();
        }
    }
}
