using AutoMapper;
using Business.Dtos.Request.CreateRequest;
using Business.Dtos.Request.DeleteRequest;
using Business.Dtos.Request.UpdateRequest;
using Business.Dtos.Response;
using Business.Dtos.Response.CreatedResponse;
using Business.Dtos.Response.DeletedResponse;
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
    public class AccountAnswerMappingProfile : Profile
    {
        public AccountAnswerMappingProfile()
        {
            CreateMap<CreateAccountAnswerRequest, AccountAnswer>().ReverseMap();
            CreateMap<UpdateAccountAnswerRequest, AccountAnswer>().ReverseMap();
            CreateMap<DeleteAccountAnswerRequest, AccountAnswer>().ReverseMap();

            CreateMap<AccountAnswer, GetListAccountAnswerResponse>()
                .ForMember(dest=> dest.AnswerName, opt=>opt.MapFrom(src=>src.Answer.Name))
                .ReverseMap();
            CreateMap<Paginate<AccountAnswer>, Paginate<GetListAccountAnswerResponse>>().ReverseMap();
            CreateMap<CreatedAccountAnswerResponse, AccountAnswer>().ReverseMap();

            CreateMap<AccountAnswer, UpdatedAccountAnswerResponse>().ReverseMap();
            CreateMap<AccountAnswer, DeletedAccountAnswerResponse>().ReverseMap();
        }
    }
}
