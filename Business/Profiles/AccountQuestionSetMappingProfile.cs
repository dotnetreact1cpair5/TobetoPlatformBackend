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
    public class AccountQuestionSetMappingProfile : Profile
    {
        public AccountQuestionSetMappingProfile()
        {
            CreateMap<CreateAccountQuestionSetRequest, AccountQuestionSet>().ReverseMap();
            CreateMap<CreatedAccountQuestionSetResponse, AccountQuestionSet>().ReverseMap();

            CreateMap<AccountQuestionSet, UpdatedAccountQuestionSetResponse>().ReverseMap();
            CreateMap<UpdateAccountQuestionSetRequest, AccountQuestionSet>().ReverseMap();

            CreateMap<AccountQuestionSet, DeletedAccountQuestionSetResponse>().ReverseMap();
            CreateMap<DeleteAccountQuestionSetRequest, AccountQuestionSet>().ReverseMap();

            CreateMap<AccountQuestionSet, GetListAccountQuestionSetResponse>()
                .ForMember(dest => dest.QuestionSetName, opt => opt.MapFrom(src => src.QuestionSet.Name))
                .ForMember(dest => dest.QuestionSetDesciption, opt => opt.MapFrom(src => src.QuestionSet.Description))
                .ForMember(dest => dest.QuestionSetDuration, opt => opt.MapFrom(src => src.QuestionSet.Duration))
                .ForMember(dest => dest.QuestionSetTotalQuestion, opt => opt.MapFrom(src => src.QuestionSet.TotalQuestion))
                .ForMember(dest => dest.QuestionSetType, opt => opt.MapFrom(src => src.QuestionSet.Type))
                .ReverseMap();
            CreateMap<Paginate<AccountQuestionSet>, Paginate<GetListAccountQuestionSetResponse>>()
                //.ForMember(dest => dest.QuestionSetName, opt => opt.MapFrom(src => src.QuestionSet.Name))
                //.ForMember(dest => dest.QuestionSetDesciption, opt => opt.MapFrom(src => src.QuestionSet.Description))
                //.ForMember(dest => dest.QuestionSetDuration, opt => opt.MapFrom(src => src.QuestionSet.Duration))
                //.ForMember(dest => dest.QuestionSetTotalQuestion, opt => opt.MapFrom(src => src.QuestionSet.TotalQuestion))
                //.ForMember(dest => dest.QuestionSetType, opt => opt.MapFrom(src => src.QuestionSet.Type))
                .ReverseMap();
            

            
        }
    }
}
