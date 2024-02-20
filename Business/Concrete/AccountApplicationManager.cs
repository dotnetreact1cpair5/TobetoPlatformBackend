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
using Core.Entities.Concrete;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace Business.Concrete
{
    public class AccountApplicationManager : IAccountApplicationService
    {
        IAccountApplicationDal _accountApplicationDal;
        IMapper _mapper;
        AccountApplicationBusinessRules _accountApplicationBusinessRules;

        public AccountApplicationManager(IAccountApplicationDal accountApplicationDal,
        IMapper mapper,
        AccountApplicationBusinessRules accountApplicationBusinessRules)
        {
            _accountApplicationDal = accountApplicationDal;
            _mapper = mapper;
            _accountApplicationBusinessRules = accountApplicationBusinessRules;
        }

        public async Task<CreatedAccountApplicationResponse> Add(CreateAccountApplicationRequest createAccountApplicationRequest)
        {
           // await _accountApplicationBusinessRules.AccountApplicationNotEmpty(createAccountApplicationRequest.AccountId,createAccountApplicationRequest.ApplicationId,createAccountApplicationRequest.ApplicationStepId);
            AccountApplication accountApplication = _mapper.Map<AccountApplication>(createAccountApplicationRequest);
            var createdAccountApplication = await _accountApplicationDal.AddAsync(accountApplication);
            CreatedAccountApplicationResponse result = _mapper.Map<CreatedAccountApplicationResponse>(createdAccountApplication);
            return result;
        }

        public async Task<DeletedAccountApplicationResponse> Delete(DeleteAccountApplicationRequest deleteAccountApplicationRequest)
        {
            AccountApplication accountApplication = _mapper.Map<AccountApplication>(deleteAccountApplicationRequest);
            var deletedAccountApplication = await _accountApplicationDal.DeleteAsync(accountApplication, false);
            DeletedAccountApplicationResponse result = _mapper.Map<DeletedAccountApplicationResponse>(deletedAccountApplication);
            return result;
        }

        public async Task<IPaginate<GetListAccountApplicationResponse>> GetByUserId(int userId)
        {
            var accountApplication = await _accountApplicationDal.GetListAsync(predicate: a => a.UserId == userId,
                 include: a => a.Include(a => a.User)
                 .Include(a=>a.Application)
                  .Include(a => a.Application).ThenInclude(a => a.Organization)
                 );
            var result = _mapper.Map<Paginate<GetListAccountApplicationResponse>>(accountApplication);
            return result;
        }

     
        public async Task<IPaginate<GetListAccountApplicationResponse>> GetListAccountApplication(PageRequest pageRequest)
        {
            var accountApplication = await _accountApplicationDal.GetListAsync(
               include: a=>a.Include(a=>a.Application)
               .Include(a=>a.User)
                .Include(a => a.Application).ThenInclude(a=>a.Organization),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListAccountApplicationResponse>>(accountApplication);
            return result;
        }

        public async Task<UpdatedAccountApplicationResponse> Update(UpdateAccountApplicationRequest updateAccountApplicationRequest)
        {
            AccountApplication accountApplication = _mapper.Map<AccountApplication>(updateAccountApplicationRequest);
            var updatedAccountApplication = await _accountApplicationDal.UpdateAsync(accountApplication);
            UpdatedAccountApplicationResponse result = _mapper.Map<UpdatedAccountApplicationResponse>(updatedAccountApplication);
            return result;
        }
    }
}
