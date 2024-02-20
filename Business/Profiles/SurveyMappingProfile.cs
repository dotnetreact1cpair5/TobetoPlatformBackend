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
    public class SurveyMappingProfile:Profile
    {
        public SurveyMappingProfile()
        {
            CreateMap<CreateSurveyRequest, Survey>().ReverseMap();
            CreateMap<UpdateSurveyRequest, Survey>().ReverseMap();
            CreateMap<DeleteSurveyRequest, Survey>().ReverseMap();

            CreateMap<Survey, CreatedSurveyResponse>().ReverseMap();
            CreateMap<Survey, UpdatedSurveyResponse>().ReverseMap();
            CreateMap<Survey, DeletedSurveyResponse>().ReverseMap();

            CreateMap<Survey, GetListSurveyResponse>().ReverseMap();
            CreateMap<Paginate<Survey>, Paginate<GetListSurveyResponse>>().ReverseMap();
        }
    }
}
