using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAccountSkillService
    {
        Task<IPaginate<GetListAccountSkillResponse>> GetListAccountSkill(PageRequest pageRequest);
        Task<CreatedAccountSkillResponse> Add(CreateAccountSkillRequest createAccountSkillRequest);
        Task<UpdatedAccountSkillResponse> Update(UpdateAccountSkillRequest updateAccountSkillRequest);
        Task<DeletedAccountSkillResponse> Delete(DeleteAccountSkillRequest deleteAccountSkillRequest);
    }
}
