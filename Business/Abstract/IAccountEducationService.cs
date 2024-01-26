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
    public interface IAccountEducationService
    {
        Task<CreatedAccountEducationResponse> Add(CreateAccountEducationRequest createAccountEducationRequest);
        Task<UpdatedAccountEducationResponse> Update(UpdateAccountEducationRequest updateAccountEducationRequest);
        Task<DeletedAccountEducationResponse> Delete(DeleteAccountEducationRequest deleteAccountEducationRequest);
        Task<IPaginate<GetListAccountEducationResponse> >GetListAccountEducation(PageRequest pageRequest);
    }
}
