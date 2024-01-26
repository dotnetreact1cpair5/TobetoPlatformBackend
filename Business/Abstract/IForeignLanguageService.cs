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
    public interface IForeignLanguageService
    {
        Task<CreatedForeignLanguageResponse> Add(CreateForeignLanguageRequest createForeignLanguageRequest);
        Task<IPaginate<GetListForeignLanguageResponse>> GetListForeignLanguage(PageRequest pageRequest);
        Task<UpdatedForeignLanguageResponse> Update(UpdateForeignLanguageRequest updateForeignLanguageRequest);
        Task<DeletedForeignLanguageResponse> Delete(DeleteForeignLanguageRequest deleteForeignLanguageRequest);
    }
}
