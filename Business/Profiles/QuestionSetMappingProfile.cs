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
    public class QuestionSetMappingProfile:Profile
    {
        public QuestionSetMappingProfile()
        {
            CreateMap<CreateQuestionSetRequest, QuestionSet>().ReverseMap();
            CreateMap<UpdateQuestionSetRequest, QuestionSet>().ReverseMap();
            CreateMap<DeleteQuestionSetRequest, QuestionSet>().ReverseMap();

            CreateMap<QuestionSet, GetListQuestionSetResponse>().ReverseMap()
            .ForMember(dest => dest.Questions, opt => opt.MapFrom(src => src.Questions.Where(a=>a.QuestionSetId == src.Id)));

            CreateMap<Paginate<QuestionSet>, Paginate<GetListQuestionSetResponse>>().ReverseMap();
            CreateMap<CreatedQuestionSetResponse, QuestionSet>().ReverseMap();

            CreateMap<QuestionSet, UpdatedQuestionSetResponse>().ReverseMap();
            CreateMap<QuestionSet, DeletedQuestionSetResponse>().ReverseMap();
        }
    }
}
