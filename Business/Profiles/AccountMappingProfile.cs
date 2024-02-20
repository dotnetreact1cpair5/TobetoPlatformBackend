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
    public class AccountMappingProfile : Profile
    {
        public AccountMappingProfile()
        {
            CreateMap<CreateAccountRequest, Account>().ReverseMap();
            CreateMap<UpdateAccountRequest, Account>().ReverseMap();
            CreateMap<DeleteAccountRequest, Account>().ReverseMap();

            CreateMap<Account, GetListAccountResponse>().ReverseMap();
            CreateMap<Paginate<Account>, Paginate<GetListAccountResponse>>().ReverseMap();

            CreateMap<Account, CreatedAccountResponse>().ReverseMap();
            CreateMap<Account, UpdatedAccountResponse>().ReverseMap();
            CreateMap<Account, DeletedAccountResponse>().ReverseMap();
        }
    } 
}
