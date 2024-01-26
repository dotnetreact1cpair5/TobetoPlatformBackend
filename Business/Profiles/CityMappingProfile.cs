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
    public class CityMappingProfile : Profile
    {
        public CityMappingProfile()
        {
            CreateMap<CreateCityRequest, City>().ReverseMap();
            CreateMap<UpdateCityRequest, City>().ReverseMap();
            CreateMap<DeleteCityRequest, City>().ReverseMap();

            CreateMap<City, GetListCityResponse>().ReverseMap();
            CreateMap<Paginate<City>, Paginate<GetListCityResponse>>().ReverseMap();
            CreateMap<CreatedCityResponse, City>().ReverseMap();

            CreateMap<City, UpdatedCityResponse>().ReverseMap();
            CreateMap<City, DeletedCityResponse>().ReverseMap();
        }
    }
}
