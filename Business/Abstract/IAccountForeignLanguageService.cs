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
    public interface IAccountForeignLanguageService
    {
        Task<CreatedAccountForeignLanguageResponse> Add(CreateAccountForeignLanguageRequest createAccountForeignLanguageRequest);
        Task<IPaginate<GetListAccountForeignLanguageResponse>> GetListAccount(PageRequest pageRequest);
        Task<UpdatedAccountForeignLanguageResponse> Update(UpdateAccountForeignLanguageRequest updateAccountForeignLanguageRequest);
        Task<DeletedAccountForeignLanguageResponse> Delete(DeleteAccountForeignLanguageRequest deleteAccountForeignLanguageRequest);
    }
}
