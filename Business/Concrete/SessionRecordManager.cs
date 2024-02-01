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
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SessionRecordManager : ISessionRecordService
    {

        ISessionRecordDal _sessionRecordDal;
        IMapper _mapper;
        SessionRecordBusinessRules _sessionRecordBusinessRules; 
        public SessionRecordManager(ISessionRecordDal sessionRecordDal, IMapper mapper,SessionRecordBusinessRules sessionRecordBusinessRules)
        {
            _sessionRecordDal = sessionRecordDal;
            _mapper = mapper;
            _sessionRecordBusinessRules = sessionRecordBusinessRules;
        }
        [ValidationAspect(typeof(CityValidator))]
        public async Task<CreatedSessionRecordResponse> Add(CreateSessionRecordRequest createSessionRecordRequest)
        {
            await _sessionRecordBusinessRules.CheckIfSessionRecordNameExists(createSessionRecordRequest.Name);
            SessionRecord sessionRecord = _mapper.Map<SessionRecord>(createSessionRecordRequest);
            var createdSessionRecord = await _sessionRecordDal.AddAsync(sessionRecord);
            CreatedSessionRecordResponse result = _mapper.Map<CreatedSessionRecordResponse>(createdSessionRecord);
            return result;
        }

        public async Task<DeletedSessionRecordResponse> Delete(DeleteSessionRecordRequest deleteSessionRecordRequest)
        {
            SessionRecord sessionRecord = await _sessionRecordDal.GetAsync(predicate: a => a.Id == deleteSessionRecordRequest.Id);
            var deletedSessionRecord = await _sessionRecordDal.DeleteAsync(sessionRecord, false);
            DeletedSessionRecordResponse result = _mapper.Map<DeletedSessionRecordResponse>(deletedSessionRecord);
            return result;
        }

        public async Task<GetListSessionRecordResponse> GetById(int SessionRecordId)
        {
            var sessionRecord = await _sessionRecordDal.GetAsync(predicate: a => a.Id == SessionRecordId);
            var result = _mapper.Map<GetListSessionRecordResponse>(sessionRecord);
            return result;
        }

        public async Task<IPaginate<GetListSessionRecordResponse>> GetListSessionRecord()
        {
            var sessionRecord = await _sessionRecordDal.GetListAsync();
            var result = _mapper.Map<Paginate<GetListSessionRecordResponse>>(sessionRecord);
            return result;
        }

        public async Task<UpdatedSessionRecordResponse> Update(UpdateSessionRecordRequest updateSessionRecordRequest)
        {
            await _sessionRecordBusinessRules.CheckIfSessionRecordNameExists(updateSessionRecordRequest.Name);
            SessionRecord sessionRecord = _mapper.Map<SessionRecord>(updateSessionRecordRequest);
            var updatedSessionRecord = await _sessionRecordDal.UpdateAsync(sessionRecord);
            UpdatedSessionRecordResponse result = _mapper.Map<UpdatedSessionRecordResponse>(updatedSessionRecord);
            return result;
        }

    }



}
