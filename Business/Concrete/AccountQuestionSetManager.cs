using AutoMapper;
using Business.Abstract;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Business.Dtos.Request.UpdateRequest;
using Business.Dtos.Request.DeleteRequest;
using Business.Dtos.Response.UpdatedResponse;
using Business.Dtos.Request.CreateRequest;
using Business.Dtos.Response.CreatedResponse;
using Business.Dtos.Response.DeletedResponse;

namespace Business.Concrete
{
    public class AccountQuestionSetManager : IAccountQuestionSetService
    {
        IAccountQuestionSetDal _accountQuestionSetDal;
        IMapper _mapper;

        public AccountQuestionSetManager(IAccountQuestionSetDal accountQuestionSetDal, IMapper mapper)
        {
            _accountQuestionSetDal = accountQuestionSetDal;
            _mapper = mapper;
        }

        public async Task<CreatedAccountQuestionSetResponse> Add(CreateAccountQuestionSetRequest createAccountQuestionSetRequest)
        {
            AccountQuestionSet accountQuestionSet = _mapper.Map<AccountQuestionSet>(createAccountQuestionSetRequest);
            var createdAccountQuestionSet = await _accountQuestionSetDal.AddAsync(accountQuestionSet);
            CreatedAccountQuestionSetResponse result = _mapper.Map<CreatedAccountQuestionSetResponse>(createdAccountQuestionSet);
            return result;
        }

        public async Task<DeletedAccountQuestionSetResponse> Delete(DeleteAccountQuestionSetRequest deleteAccountQuestionSetRequest)
        {
            AccountQuestionSet accountQuestionSet = await _accountQuestionSetDal.GetAsync(a => a.Id == deleteAccountQuestionSetRequest.Id);
            var deletedAccountQuestionSet = await _accountQuestionSetDal.DeleteAsync(accountQuestionSet, false);
            DeletedAccountQuestionSetResponse result = _mapper.Map<DeletedAccountQuestionSetResponse>(deletedAccountQuestionSet);
            return result;
        }

        //public async Task<AccountTestResultDto> GetById(int accountId)
        //{
        //    var accountQuestionSet = await _accountQuestionSetDal.GetAsync(
        //        predicate: a => a.Id == accountId,
        //        include: b => b.Include(c => c.));
        //    //var result = _mapper.Map<Paginate<GetListAccountQuestionSetResponse>>(accountQuestionSet);
        //    return result;
        //}

        public async Task<IPaginate<GetListAccountQuestionSetResponse>> GetList(PageRequest pageRequest)
        {
            var accountQuestionSet = await _accountQuestionSetDal.GetListAsync(
                include: a => a.Include(b => b.QuestionSet),
                orderBy: a => a.OrderBy(a => a.Id),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListAccountQuestionSetResponse>>(accountQuestionSet);
            return result;
        }

        public async Task<UpdatedAccountQuestionSetResponse> Update(UpdateAccountQuestionSetRequest updateAccountQuestionSetRequest)
        {
            AccountQuestionSet accountQuestionSet = await _accountQuestionSetDal.GetAsync(a => a.Id == updateAccountQuestionSetRequest.Id);
            _mapper.Map(updateAccountQuestionSetRequest, accountQuestionSet);
            var updatedAccountQuestionSet = await _accountQuestionSetDal.UpdateAsync(accountQuestionSet);
            UpdatedAccountQuestionSetResponse result = _mapper.Map<UpdatedAccountQuestionSetResponse>(updatedAccountQuestionSet);
            return result;
        }
    }
}
