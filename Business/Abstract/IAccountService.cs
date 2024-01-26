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
    public interface IAccountService
    {
        Task<CreatedAccountResponse> Add(CreateAccountRequest  createAccountRequest);
        Task<IPaginate<GetListAccountResponse>> GetListAccount(PageRequest pageRequest);
        Task<UpdatedAccountResponse> Update(UpdateAccountRequest updateAccountRequest);
        Task<DeletedAccountResponse> Delete(DeleteAccountRequest deleteAccountRequest);
    }
}

