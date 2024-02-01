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

    public class CountryMappingProfile : Profile
    {
        public CountryMappingProfile()
        {
            CreateMap<CreateCountryRequest, Country>().ReverseMap();
            CreateMap<UpdateCountryRequest, Country>().ReverseMap();
            CreateMap<DeleteCountryRequest, Country>().ReverseMap();

            CreateMap<Country, GetListCountryResponse>().ReverseMap();
            CreateMap<Paginate<Country>, Paginate<GetListCountryResponse>>().ReverseMap();
            CreateMap<CreatedCountryResponse, Country>().ReverseMap();

            CreateMap<Country, UpdatedCountryResponse>().ReverseMap();
            CreateMap<Country, DeletedCountryResponse>().ReverseMap();
        }
    }
}

