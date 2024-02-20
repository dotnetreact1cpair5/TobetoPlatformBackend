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
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AccountExperienceManager : IAccountExperienceService
    {
        IAccountExperienceDal _accountExperienceDal;
        IMapper _mapper;
        AccountExperienceBusinessRules _accountExperienceBusinessRules;

        public AccountExperienceManager(IAccountExperienceDal accountExperienceDal, IMapper mapper, AccountExperienceBusinessRules accountExperienceBusinessRules)
        {
            _accountExperienceDal = accountExperienceDal;
            _mapper = mapper;
            _accountExperienceBusinessRules = accountExperienceBusinessRules;
        }

        [ValidationAspect(typeof(AccountExperienceValidator))]
        public async Task<CreatedAccountExperienceResponse> Add(CreateAccountExperienceRequest createAccountExperienceRequest)
        {
            await _accountExperienceBusinessRules.AccountExperienceRule();
            var category = _mapper.Map<AccountExperience>(createAccountExperienceRequest);
            var createdAccountExperience = await _accountExperienceDal.AddAsync(category);
            var createdAccountExperienceResponse = _mapper.Map<CreatedAccountExperienceResponse>(createdAccountExperience);
            return createdAccountExperienceResponse;
        }

        public async Task<DeletedAccountExperienceResponse> Delete(DeleteAccountExperienceRequest deleteAccountExperienceRequest)
        {
            AccountExperience accountExperience = await _accountExperienceDal.GetAsync(ae => ae.Id == deleteAccountExperienceRequest.Id);
            var deletedAccountExperience = await _accountExperienceDal.DeleteAsync(accountExperience, false);
            DeletedAccountExperienceResponse result = _mapper.Map<DeletedAccountExperienceResponse>(deletedAccountExperience);
            return result;
        }

        public async Task<IPaginate<GetListAccountExperienceResponse>> GetListAccountExperience(PageRequest pageRequest)
        {
            var experiences = await _accountExperienceDal.GetListAsync(
                orderBy: e => e.OrderBy(e => e.Id),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var mapped = _mapper.Map<Paginate<GetListAccountExperienceResponse>>(experiences);
            return mapped;
        }

        public async Task<UpdatedAccountExperienceResponse> Update(UpdateAccountExperienceRequest updateAccountExperienceRequest)
        {
            AccountExperience accountExperience = await _accountExperienceDal.GetAsync(ae => ae.Id == updateAccountExperienceRequest.Id);
            var updatedAccountExperience = await _accountExperienceDal.UpdateAsync(accountExperience);
            UpdatedAccountExperienceResponse result = _mapper.Map<UpdatedAccountExperienceResponse>(updatedAccountExperience);
            return result;
        }
    }
}
