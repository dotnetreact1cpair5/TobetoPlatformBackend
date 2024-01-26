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
    public interface IForeignLanguageLevelService
    {
        Task<CreatedForeignLanguageLevelResponse> Add(CreateForeignLanguageLevelRequest createForeignLanguageLevelRequest);
        Task<IPaginate<GetListForeignLanguageLevelResponse>> GetListForeignLanguageLevel(PageRequest pageRequest);
        Task<UpdatedForeignLanguageLevelResponse> Update(UpdateForeignLanguageLevelRequest updateForeignLanguageLevelRequest);
        Task<DeletedForeignLanguageLevelResponse> Delete(DeleteForeignLanguageLevelRequest deleteForeignLanguageLevelRequest);
    }
}
