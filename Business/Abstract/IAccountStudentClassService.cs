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
    public interface IAccountStudentClassService
    {
        Task<CreatedAccountStudentClassResponse> Add(CreateAccountStudentClassRequest createAccountStudentClassRequest);
        Task<IPaginate<GetListAccountStudentClassResponse>> GetListAccountStudentClass();
        Task<UpdatedAccountStudentClassResponse> Update(UpdateAccountStudentClassRequest updateAccountStudentClassRequest);
        Task<DeletedAccountStudentClassResponse> Delete(DeleteAccountStudentClassRequest deleteAccountStudentClassRequest);
        Task<GetListAccountStudentClassResponse> GetById(int accountStudentClassId);
    }
}
