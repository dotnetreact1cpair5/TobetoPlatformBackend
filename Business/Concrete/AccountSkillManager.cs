using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
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
                //orderBy: ac => ac.OrderBy(ac => ac.SkillId),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListAccountSkillResponse>>(accountSkills);
            return result;
        }

        public async Task<UpdatedAccountSkillResponse> Update(UpdateAccountSkillRequest updateAccountSkillRequest)
        {
            AccountSkill accountSkill = _mapper.Map<AccountSkill>(updateAccountSkillRequest);
            var updatedAccountSkill = await _accountSkillDal.UpdateAsync(accountSkill);
            UpdatedAccountSkillResponse result = _mapper.Map<UpdatedAccountSkillResponse>(updatedAccountSkill);
            return result;
        }
    }
}
