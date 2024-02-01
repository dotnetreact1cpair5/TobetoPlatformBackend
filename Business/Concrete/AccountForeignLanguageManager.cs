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
    public class AccountForeignLanguageManager : IAccountForeignLanguageService
    {
        IAccountForeignLanguageDal _accountForeignLanguageDal;
        IMapper _mapper;
        AccountForeignLanguageBusinessRules _accountForeignLanguageRules;

        public AccountForeignLanguageManager(IAccountForeignLanguageDal accountForeignLanguageDal, IMapper mapper, AccountForeignLanguageBusinessRules accountForeignLanguageRules)
        {
            _accountForeignLanguageDal = accountForeignLanguageDal;
            _mapper = mapper;
            _accountForeignLanguageRules = accountForeignLanguageRules;
        }
        public async Task<CreatedAccountForeignLanguageResponse> Add(CreateAccountForeignLanguageRequest createAccountForeignLanguageRequest)
        {
            AccountForeignLanguage accountForeignLanguage = _mapper.Map<AccountForeignLanguage>(createAccountForeignLanguageRequest);
            var createdAccountForeignLanguage = await _accountForeignLanguageDal.AddAsync(accountForeignLanguage);
            CreatedAccountForeignLanguageResponse result = _mapper.Map<CreatedAccountForeignLanguageResponse>(createdAccountForeignLanguage);
            return result;
        }

        public async Task<DeletedAccountForeignLanguageResponse> Delete(DeleteAccountForeignLanguageRequest deleteAccountForeignLanguageRequest)
        {
            AccountForeignLanguage accountForeignLanguage = await _accountForeignLanguageDal.GetAsync(afl => afl.Id == deleteAccountForeignLanguageRequest.Id);
            var deletedAccountForeignLanguage = await _accountForeignLanguageDal.DeleteAsync(accountForeignLanguage, false);
            DeletedAccountForeignLanguageResponse result = _mapper.Map<DeletedAccountForeignLanguageResponse>(deletedAccountForeignLanguage);
            return result;
        }

        public async Task<IPaginate<GetListAccountForeignLanguageResponse>> GetListAccount(PageRequest pageRequest)
        {
            var accountForeignLanguage = await _accountForeignLanguageDal.GetListAsync(
                orderBy: a => a.OrderBy(a => a.Id),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListAccountForeignLanguageResponse>>(accountForeignLanguage);
            return result;
        }

        public async Task<UpdatedAccountForeignLanguageResponse> Update(UpdateAccountForeignLanguageRequest updateAccountForeignLanguageRequest)
        {
            AccountForeignLanguage accountForeignLanguage = await _accountForeignLanguageDal.GetAsync(afl => afl.Id == updateAccountForeignLanguageRequest.Id);
            _mapper.Map(updateAccountForeignLanguageRequest, accountForeignLanguage);
            var updatedAccountForeignLanguage = await _accountForeignLanguageDal.UpdateAsync(accountForeignLanguage);
            UpdatedAccountForeignLanguageResponse result = _mapper.Map<UpdatedAccountForeignLanguageResponse>(updatedAccountForeignLanguage);
            return result;
        }
    }
}
