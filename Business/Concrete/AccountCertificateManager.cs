using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
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
    public class AccountCertificateManager : IAccountCertificateService
    {
        IAccountCertificateDal _accountCertificateDal;
        IMapper _mapper;
        AccountCertificateBusinessRules _accountCertificateBusinessRules;

        public AccountCertificateManager(IAccountCertificateDal accountCertificateDal, IMapper mapper, AccountCertificateBusinessRules accountCertificateBusinessRules)
        {
            _accountCertificateDal = accountCertificateDal;
            _mapper = mapper;
            _accountCertificateBusinessRules = accountCertificateBusinessRules;
        }


        public async Task<CreatedAccountCertificateResponse> Add(CreateAccountCertificateRequest createCertificateRequest)
        {
            await _accountCertificateBusinessRules.FileNameCantBeNull(createCertificateRequest.Name);
            await _accountCertificateBusinessRules.RequiredFileFormats(createCertificateRequest.Name);
            await _accountCertificateBusinessRules.FileNameIsTooLong(createCertificateRequest.Name);
            await _accountCertificateBusinessRules.NotValidCharacters(createCertificateRequest.Name);
            await _accountCertificateBusinessRules.MustBeAccountDefined(createCertificateRequest.AccountId);

            AccountCertificate certificate = _mapper.Map<AccountCertificate>(createCertificateRequest);

            var createdCertificate = await _accountCertificateDal.AddAsync(certificate);
            CreatedAccountCertificateResponse result = _mapper.Map<CreatedAccountCertificateResponse>(createdCertificate);
            return result;
        }

        public async Task<DeletedAccountCertificateResponse> Delete(DeleteAccountCertificateRequest deleteAccountCertificateRequest)
        {
            AccountCertificate accountCertificate = await _accountCertificateDal.GetAsync(d => d.Id == deleteAccountCertificateRequest.Id);
            var deletedAccountCertificate = await _accountCertificateDal.DeleteAsync(accountCertificate, false);
            DeletedAccountCertificateResponse result = _mapper.Map<DeletedAccountCertificateResponse>(deletedAccountCertificate);
            return result;
        }

        public async Task<IPaginate<GetListAccountCertificateResponse>> GetListAccountCertificate(PageRequest pageRequest)
        {
            var accountCertificate = await _accountCertificateDal.GetListAsync(
                orderBy: c => c.OrderBy(c => c.Name).ThenByDescending(c => c.CreatedDate),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize
            );
            var result = _mapper.Map<Paginate<GetListAccountCertificateResponse>>(accountCertificate);
            return result;
        }

        public async Task<UpdatedAccountCertificateResponse> Update(UpdateAccountCertificateRequest updateAccountCertificateRequest)
        {
            await _accountCertificateBusinessRules.FileNameCantBeNull(updateAccountCertificateRequest.Name);
            await _accountCertificateBusinessRules.RequiredFileFormats(updateAccountCertificateRequest.Name);
            await _accountCertificateBusinessRules.FileNameIsTooLong(updateAccountCertificateRequest.Name);
            await _accountCertificateBusinessRules.NotValidCharacters(updateAccountCertificateRequest.Name);
            await _accountCertificateBusinessRules.MustBeAccountDefined(updateAccountCertificateRequest.AccountId);

            AccountCertificate accountCertificate = await _accountCertificateDal.GetAsync(d => d.Id == updateAccountCertificateRequest.Id);
            _mapper.Map(updateAccountCertificateRequest, accountCertificate);
            var updatedAccountCertificate = await _accountCertificateDal.UpdateAsync(accountCertificate);
            UpdatedAccountCertificateResponse result = _mapper.Map<UpdatedAccountCertificateResponse>(updatedAccountCertificate);
            return result;
        }
    }
}
