using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request.CreateRequest;
using Business.Dtos.Request.DeleteRequest;
using Business.Dtos.Request.UpdateRequest;
using Business.Dtos.Response.CreatedResponse;
using Business.Dtos.Response.DeletedResponse;
using Business.Dtos.Response.GetListResponse;
using Business.Dtos.Response.UpdatedResponse;
using Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SurveyManager : ISurveyService
    {
        ISurveyDal _surveyDal;
        IMapper _mapper;
        //SurveyBusinessRules _surveyBusinessRules;

        public SurveyManager(ISurveyDal surveyDal,
        IMapper mapper)
        {
            _surveyDal = surveyDal;
            _mapper = mapper;
            //_surveyBusinessRules = surveyBusinessRules;
        }

        public async Task<CreatedSurveyResponse> Add(CreateSurveyRequest createSurveyRequest)
        {
            Survey survey = _mapper.Map<Survey>(createSurveyRequest);
            var createdSurvey = await _surveyDal.AddAsync(survey);
            CreatedSurveyResponse result = _mapper.Map<CreatedSurveyResponse>(createdSurvey);
            return result;
        }

        public async Task<DeletedSurveyResponse> Delete(DeleteSurveyRequest deleteSurveyRequest)
        {
            Survey survey = _mapper.Map<Survey>(deleteSurveyRequest);
            var deletedSurvey = await _surveyDal.DeleteAsync(survey, false);
            DeletedSurveyResponse result = _mapper.Map<DeletedSurveyResponse>(deletedSurvey);
            return result;
        }

        public async Task<IPaginate<GetListSurveyResponse>> GetListSurvey(PageRequest pageRequest)
        {
            var survey = await _surveyDal.GetListAsync(
                orderBy: s => s.OrderBy(s => s.Id),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListSurveyResponse>>(survey);
            return result;
        }

        public async Task<UpdatedSurveyResponse> Update(UpdateSurveyRequest updateSurveyRequest)
        {
            Survey survey = _mapper.Map<Survey>(updateSurveyRequest);
            var updatedSurvey = await _surveyDal.UpdateAsync(survey);
            UpdatedSurveyResponse result = _mapper.Map<UpdatedSurveyResponse>(updatedSurvey);
            return result;
        }
    }
}
