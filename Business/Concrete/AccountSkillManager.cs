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
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AccountSkillManager : IAccountSkillService
    {
        IAccountSkillDal _accountSkillDal;
        IMapper _mapper;

        public AccountSkillManager(IAccountSkillDal accountSkillDal,
        IMapper mapper)
        {
            _accountSkillDal = accountSkillDal;
            _mapper = mapper;
        }

        public async Task<CreatedAccountSkillResponse> Add(CreateAccountSkillRequest createAccountSkillRequest)
        {
            AccountSkill accountSkill = _mapper.Map<AccountSkill>(createAccountSkillRequest);
            var createdAccountSkill = await _accountSkillDal.AddAsync(accountSkill);
            CreatedAccountSkillResponse result = _mapper.Map<CreatedAccountSkillResponse>(createdAccountSkill);
            return result;
        }

        public async Task<DeletedAccountSkillResponse> Delete(DeleteAccountSkillRequest deleteAccountSkillRequest)
        {
            AccountSkill accountSkill = await _accountSkillDal.GetAsync(d => d.Id == deleteAccountSkillRequest.Id);
            var deletedAccountSkill = await _accountSkillDal.DeleteAsync(accountSkill, false);
            DeletedAccountSkillResponse result = _mapper.Map<DeletedAccountSkillResponse>(deletedAccountSkill);
            return result;
        }

        public async Task<IPaginate<GetListAccountSkillResponse>> GetListAccountSkill(PageRequest pageRequest)
        {
            var accountSkills = await _accountSkillDal.GetListAsync(
                include: a => a.Include(b => b.Skill),
                orderBy: a => a.OrderBy(a => a.Id),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListAccountSkillResponse>>(accountSkills);
            return result;
        }

        public async Task<UpdatedAccountSkillResponse> Update(UpdateAccountSkillRequest updateAccountSkillRequest)
        {
            AccountSkill accountSkill = await _accountSkillDal.GetAsync(a => a.Id == updateAccountSkillRequest.Id);
            _mapper.Map(updateAccountSkillRequest, accountSkill);
            var updatedAccountSkill = await _accountSkillDal.UpdateAsync(accountSkill);
            UpdatedAccountSkillResponse result = _mapper.Map<UpdatedAccountSkillResponse>(updatedAccountSkill);
            return result;
        }
    }
}
