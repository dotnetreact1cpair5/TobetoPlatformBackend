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
    public class AnswerMappingProfile:Profile
    {
        public AnswerMappingProfile()
        {
            CreateMap<CreateAnswerRequest, Answer>().ReverseMap();
            CreateMap<UpdateAnswerRequest, Answer>().ReverseMap();
            CreateMap<DeleteAnswerRequest, Answer>().ReverseMap();

            CreateMap<Answer, GetListAnswerResponse>()
                .ForMember(dest => dest.QuestionId, opt => opt.MapFrom(src => src.Question.Id))
                .ReverseMap();
            CreateMap<Paginate<Answer>, Paginate<GetListAnswerResponse>>().ReverseMap();
            CreateMap<CreatedAnswerResponse, Answer>().ReverseMap();

            CreateMap<Answer, UpdatedAnswerResponse>().ReverseMap();
            CreateMap<Answer, DeletedAnswerResponse>().ReverseMap();
        }
    }
}
