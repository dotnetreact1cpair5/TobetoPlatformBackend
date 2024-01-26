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
    public interface IAccountCertificateService 
    {
        Task<CreatedAccountCertificateResponse> Add(CreateAccountCertificateRequest createAccountCertificateRequest);
        Task<IPaginate<GetListAccountCertificateResponse>> GetListAccountCertificate(PageRequest pageRequest);
        Task<UpdatedAccountCertificateResponse> Update(UpdateAccountCertificateRequest updateAccountCertificateRequest);
        Task<DeletedAccountCertificateResponse> Delete(DeleteAccountCertificateRequest deleteAccountCertificateRequest);
    }
}
