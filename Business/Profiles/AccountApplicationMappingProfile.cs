﻿using AutoMapper;
using Business.Dtos.Request.CreateRequest;
using Business.Dtos.Request.DeleteRequest;
using Business.Dtos.Request.UpdateRequest;
using Business.Dtos.Response.CreatedResponse;
using Business.Dtos.Response.DeletedResponse;
using Business.Dtos.Response.GetListResponse;
using Business.Dtos.Response.UpdatedResponse;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class AccountApplicationMappingProfile:Profile
    {
        public AccountApplicationMappingProfile()
        {
            CreateMap<CreateAccountApplicationRequest, AccountApplication>().ReverseMap();
            CreateMap<UpdateAccountApplicationRequest, AccountApplication>().ReverseMap();
            CreateMap<DeleteAccountApplicationRequest, AccountApplication>().ReverseMap();

            CreateMap<AccountApplication, CreatedAccountApplicationResponse>().ReverseMap();
            CreateMap<AccountApplication, UpdatedAccountApplicationResponse>().ReverseMap();
            CreateMap<AccountApplication, DeletedAccountApplicationResponse>().ReverseMap();

            CreateMap<AccountApplication, GetListAccountApplicationResponse>()
                .ForMember(dest=>dest.UserFirsLastName,opt=>opt.MapFrom(src=>src.User.FirstName+ " "+src.User.LastName))
                 .ForMember(dest=>dest.ApplicationName,opt=>opt.MapFrom(src=>src.Application.DocumentName))
                  .ForMember(dest => dest.Organization, opt => opt.MapFrom(src => src.Application.Organization.Name))
                   .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Application.Title))
                .ReverseMap();
            CreateMap<Paginate<AccountApplication>, Paginate<GetListAccountApplicationResponse>>().ReverseMap();
        }
    }
}
