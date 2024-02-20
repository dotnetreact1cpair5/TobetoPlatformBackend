using Business.Dtos.Request.CreateRequest;
using Business.Dtos.Request.DeleteRequest;
using Business.Dtos.Request.UpdateRequest;
using Business.Dtos.Response;
using Business.Dtos.Response.CreatedResponse;
using Business.Dtos.Response.DeletedResponse;
using Business.Dtos.Response.UpdatedResponse;
using Core.DataAccess.Paging;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAccountQuestionSetService
    {
        Task<CreatedAccountQuestionSetResponse> Add(CreateAccountQuestionSetRequest createAccountQuestionSetRequest);
        Task<IPaginate<GetListAccountQuestionSetResponse>> GetList(PageRequest pageRequest);
        Task<UpdatedAccountQuestionSetResponse> Update(UpdateAccountQuestionSetRequest updateAccountQuestionSetRequest);
        Task<DeletedAccountQuestionSetResponse> Delete(DeleteAccountQuestionSetRequest deleteAccountQuestionSetRequest);
    }
}
