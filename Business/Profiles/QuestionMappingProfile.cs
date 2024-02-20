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
    public class QuestionMappingProfile:Profile
    {
        public QuestionMappingProfile()
        {
            CreateMap<CreateQuestionRequest, Question>().ReverseMap();
            CreateMap<UpdateQuestionRequest, Question>().ReverseMap();
            CreateMap<DeleteQuestionRequest, Question>().ReverseMap();

            CreateMap<Question, GetListQuestionResponse>()
                .ForMember(dest => dest.Answers, opt => opt.MapFrom(src => src.Answers.Where(a => a.QuestionId == src.Id)))
                .ReverseMap();
            CreateMap<Paginate<Question>, Paginate<GetListQuestionResponse>>().ReverseMap();
            CreateMap<CreatedQuestionResponse, Question>().ReverseMap();

            CreateMap<Question, UpdatedQuestionResponse>().ReverseMap();
            CreateMap<Question, DeletedQuestionResponse>().ReverseMap();
        }
    }
}
