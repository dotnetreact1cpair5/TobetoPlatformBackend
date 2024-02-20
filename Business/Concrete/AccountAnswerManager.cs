using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request.CreateRequest;
using Business.Dtos.Request.DeleteRequest;
using Business.Dtos.Request.UpdateRequest;
using Business.Dtos.Response;
using Business.Dtos.Response.CreatedResponse;
using Business.Dtos.Response.DeletedResponse;
using Business.Dtos.Response.UpdatedResponse;
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
    public class AccountAnswerManager : IAccountAnswerService
    {
        IAccountAnswerDal _accountAnswerDal;
        IMapper _mapper;

        public AccountAnswerManager(IAccountAnswerDal accountAnswerDal, IMapper mapper)
        {
            _accountAnswerDal = accountAnswerDal;
            _mapper = mapper;
        }

        public async Task<CreatedAccountAnswerResponse> Add(CreateAccountAnswerRequest createAccountAnswerRequest)
        {
            AccountAnswer accountAnswer = _mapper.Map<AccountAnswer>(createAccountAnswerRequest);
            var createdAccountAnswer = await _accountAnswerDal.AddAsync(accountAnswer);
            CreatedAccountAnswerResponse result = _mapper.Map<CreatedAccountAnswerResponse>(createdAccountAnswer);
            return result;
        }

        public async Task<DeletedAccountAnswerResponse> Delete(DeleteAccountAnswerRequest deleteAccountAnswerRequest)
        {
            AccountAnswer accountAnswer = await _accountAnswerDal.GetAsync(a => a.Id == deleteAccountAnswerRequest.Id);
            var deletedAccountAnswer = await _accountAnswerDal.DeleteAsync(accountAnswer, false);
            DeletedAccountAnswerResponse result = _mapper.Map<DeletedAccountAnswerResponse>(deletedAccountAnswer);
            return result;
        }

        public async Task<IPaginate<GetListAccountAnswerResponse>> GetList(PageRequest pageRequest)
        {
            var accountAnswer = await _accountAnswerDal.GetListAsync(
                include: a => a.Include(b => b.Answer).ThenInclude(c => c.Question).ThenInclude(d => d.QuestionSet),
                //.Include(answer=>answer.Answer),
                //.Select(b => new {
                //    AnswerCount = b.Answer.Id.Count()
                //}),
                orderBy: a => a.OrderBy(a => a.Id),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListAccountAnswerResponse>>(accountAnswer);
            return result;
        }

        public async Task<UpdatedAccountAnswerResponse> Update(UpdateAccountAnswerRequest updateAccountAnswerRequest)
        {
            AccountAnswer accountAnswer = await _accountAnswerDal.GetAsync(a => a.Id == updateAccountAnswerRequest.Id);
            _mapper.Map(updateAccountAnswerRequest, accountAnswer);
            var updatedAccountAnswer = await _accountAnswerDal.UpdateAsync(accountAnswer);
            UpdatedAccountAnswerResponse result = _mapper.Map<UpdatedAccountAnswerResponse>(updatedAccountAnswer);
            return result;
        }
    }
}
