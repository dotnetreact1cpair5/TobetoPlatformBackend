﻿using AutoMapper;
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
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AccountManager : IAccountService
    {
        IAccountDal _accountDal;
        IMapper _mapper;
        AccountBusinessRules _accountBusinessRules;
        public AccountManager(IAccountDal accountDal, IMapper mapper, AccountBusinessRules accountBusinessRules)
        {
            _accountDal = accountDal;
            _mapper = mapper;
            _accountBusinessRules = accountBusinessRules;
        }
        public async Task<CreatedAccountResponse> Add(CreateAccountRequest createAccountRequest)
        {
            await _accountBusinessRules.MaxNationalIdLength(createAccountRequest.NationalId);
            await _accountBusinessRules.MailFormat(createAccountRequest.Email);
            Account account = _mapper.Map<Account>(createAccountRequest);
            var createdAccount = await _accountDal.AddAsync(account);
            CreatedAccountResponse result = _mapper.Map<CreatedAccountResponse>(createdAccount);
            return result;
        }

        public async Task<DeletedAccountResponse> Delete(DeleteAccountRequest deleteAccountRequest)
        {
            Account account = await _accountDal.GetAsync(a => a.Id == deleteAccountRequest.Id);
            var deletedAccount = await _accountDal.DeleteAsync(account, false);
            DeletedAccountResponse result = _mapper.Map<DeletedAccountResponse>(deletedAccount);
            return result;
        }

        public async Task<IPaginate<GetListAccountResponse>> GetListAccount(PageRequest pageRequest)
        {
            var account = await _accountDal.GetListAsync(
                include: a => a.Include(b => b.Country).ThenInclude(c => c.Cities).ThenInclude(d => d.Districts),
                orderBy: a => a.OrderBy(a => a.Id),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListAccountResponse>>(account);
            return result;
        }

        public async Task<UpdatedAccountResponse> Update(UpdateAccountRequest updateAccountRequest)
        {
            Account account = await _accountDal.GetAsync(a => a.Id == updateAccountRequest.Id);
            _mapper.Map(updateAccountRequest, account);
            var updatedAccount = await _accountDal.UpdateAsync(account);
            UpdatedAccountResponse result = _mapper.Map<UpdatedAccountResponse>(updatedAccount);
            return result;
        }
    }
}
