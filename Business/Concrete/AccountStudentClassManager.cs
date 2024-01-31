using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AccountStudentClassManager : IAccountStudentClassService
    {

        IAccountStudentClassDal _accountStudentClassDal;
        IMapper _mapper;
        public AccountStudentClassManager(IAccountStudentClassDal accountStudentClassDal, IMapper mapper)
        {
            _accountStudentClassDal = accountStudentClassDal;
            _mapper = mapper;
        }

        public async Task<CreatedAccountStudentClassResponse> Add(CreateAccountStudentClassRequest createAccountStudentClassRequest)
        {
            AccountStudentClass accountStudentClass = _mapper.Map<AccountStudentClass>(createAccountStudentClassRequest);
            var createdAccountStudentClass = await _accountStudentClassDal.AddAsync(accountStudentClass);
            CreatedAccountStudentClassResponse result = _mapper.Map<CreatedAccountStudentClassResponse>(createdAccountStudentClass);
            return result;
        }

        public async Task<DeletedAccountStudentClassResponse> Delete(DeleteAccountStudentClassRequest deleteAccountStudentClassRequest)
        {
            AccountStudentClass accountStudentClass = await _accountStudentClassDal.GetAsync(predicate: a => a.Id == deleteAccountStudentClassRequest.Id);
            var deletedAccountStudentClass = await _accountStudentClassDal.DeleteAsync(accountStudentClass, false);
            DeletedAccountStudentClassResponse result = _mapper.Map<DeletedAccountStudentClassResponse>(deletedAccountStudentClass);
            return result;
        }

        public async Task<GetListAccountStudentClassResponse> GetById(int accountStudentClassId)
        {
            var accountStudentClass = await _accountStudentClassDal.GetAsync(predicate: a => a.Id == accountStudentClassId);
            var result = _mapper.Map<GetListAccountStudentClassResponse>(accountStudentClass);
            return result;
        }

        public async Task<IPaginate<GetListAccountStudentClassResponse>> GetListAccountStudentClass()
        {
            var accountStudentClass = await _accountStudentClassDal.GetListAsync(
                include: a=>a.Include(a=>a.StudentClass).Include(a=>a.Account).ThenInclude(ca=>ca.User)
                );
            var result = _mapper.Map<Paginate<GetListAccountStudentClassResponse>>(accountStudentClass);
            return result;
        }

        public async Task<UpdatedAccountStudentClassResponse> Update(UpdateAccountStudentClassRequest updateAccountStudentClassRequest)
        {
            AccountStudentClass accountStudentClass = _mapper.Map<AccountStudentClass>(updateAccountStudentClassRequest);
            var updatedAccountStudentClass = await _accountStudentClassDal.UpdateAsync(accountStudentClass);
            UpdatedAccountStudentClassResponse result = _mapper.Map<UpdatedAccountStudentClassResponse>(updatedAccountStudentClass);
            return result;
        }


    }
}
