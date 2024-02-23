using AutoMapper;
using Business.Dtos.Request;
using Business.Dtos.Request.CreateRequest;
using Business.Dtos.Request.DeleteRequest;
using Business.Dtos.Request.UpdateRequest;
using Business.Dtos.Response.CreatedResponse;
using Business.Dtos.Response.DeletedResponse;
using Business.Dtos.Response.GetListResponse;
using Business.Dtos.Response.UpdatedResponse;
using Core.DataAccess.Paging;
using Core.Entities.Concrete;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class AccountMappingProfile : Profile
    {
        public AccountMappingProfile()
        {
            CreateMap<CreateAccountRequest, Account>().ReverseMap();
            CreateMap<Account, CreatedAccountResponse>()
            .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => $"{src.Country.Code} {src.PhoneNumber} {src.User.FirstName}")).ReverseMap();
            CreateMap<UpdateAccountRequest, Account>().ReverseMap();
            CreateMap<Account, UpdatedAccountResponse>().ReverseMap();
            CreateMap<DeleteAccountRequest, Account>().ReverseMap();
            CreateMap<Account, DeletedAccountResponse>().ReverseMap();
            CreateMap<Paginate<Account>, Paginate<GetListAccountResponse>>().ReverseMap();
            CreateMap<Account, GetListAccountResponse>().ReverseMap();
            CreateMap<GetByIdAccountRequest, Account>().ReverseMap();



            //.ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => $"{src.Country.Code} {src.PhoneNumber}"))
            //.ForMember(dest => dest.CountryId, opt => opt.MapFrom(src => src.Country.Id))
            //.ForMember(dest => dest.CityId, opt => opt.MapFrom(src => src.City.Id))
            //.ForMember(dest => dest.DistrictId, opt => opt.MapFrom(src => src.District.Id))

            //.ForMember(dest => dest.CountryId, opt => opt.MapFrom(src => src.Country.Id))
            //.ForMember(dest => dest.CityId, opt => opt.MapFrom(src => src.City.Id))
            //.ForMember(dest => dest.DistrictId, opt => opt.MapFrom(src => src.District.Id))

            //.ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => $"{src.Country.Code} {src.PhoneNumber}"))
            //.ForMember(dest => dest.CountryName, opt => opt.MapFrom(src => $"{src.Country.Name}"))
            //.ForMember(dest => dest.CityName, opt => opt.MapFrom(src => $"{src.City.Name}"))
            //.ForMember(dest => dest.DistrictName, opt => opt.MapFrom(src => $"{src.District.Name}"))


            //.ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => $"{src.Country.Code} {src.PhoneNumber}"))
            //.ForMember(dest => dest.CountryId, opt => opt.MapFrom(src => src.Country.Id))
            //.ForMember(dest => dest.CityId, opt => opt.MapFrom(src => src.City.Id))
            //.ForMember(dest => dest.DistrictId, opt => opt.MapFrom(src => src.District.Id))


            //.ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => $"{src.Country.Code} {src.PhoneNumber}"))
            //.ForMember(dest => dest.CountryId, opt => opt.MapFrom(src => src.Country.Id))
            //.ForMember(dest => dest.CityId, opt => opt.MapFrom(src => src.City.Id))
            //.ForMember(dest => dest.DistrictId, opt => opt.MapFrom(src => src.District.Id))
        }
    }
}
