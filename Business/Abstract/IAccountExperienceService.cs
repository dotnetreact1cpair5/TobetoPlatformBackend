using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAccountExperienceService
    {
        Task<CreatedAccountExperienceResponse> Add(CreateAccountExperienceRequest createAccountExperienceRequest);

        Task<IPaginate<GetListAccountExperienceResponse>> GetListAccountExperience(PageRequest pageRequest);

        Task<UpdatedAccountExperienceResponse> Update(UpdateAccountExperienceRequest updateAccountExperienceRequest);

        Task<DeletedAccountExperienceResponse> Delete(DeleteAccountExperienceRequest deleteAccountExperienceRequest);
    }
}
