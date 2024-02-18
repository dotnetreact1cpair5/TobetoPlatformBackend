using Business.Dtos.Request.CreateRequest;
using Business.Dtos.Request.DeleteRequest;
using Business.Dtos.Request.UpdateRequest;
using Business.Dtos.Response.CreatedResponse;
using Business.Dtos.Response.DeletedResponse;
using Business.Dtos.Response.GetListResponse;
using Business.Dtos.Response.UpdatedResponse;
using Core.DataAccess.Paging;

namespace Business.Abstract
{
    public interface IAccountApplicationService
    {
        Task<IPaginate<GetListAccountApplicationResponse>> GetListAccountApplication(PageRequest pageRequest);
        Task<CreatedAccountApplicationResponse> Add(CreateAccountApplicationRequest createAccountApplicationRequest);
        Task<UpdatedAccountApplicationResponse> Update(UpdateAccountApplicationRequest updateAccountApplicationRequest);
        Task<DeletedAccountApplicationResponse> Delete(DeleteAccountApplicationRequest deleteAccountApplicationRequest);
        Task<IPaginate<GetListAccountApplicationResponse>> GetByUserId(int userId);

    }
}
