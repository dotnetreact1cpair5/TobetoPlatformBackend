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
    public interface IUniversityService
    {
        Task<CreatedUniversityResponse> Add(CreateUniversityRequest createUniversityRequest);
        Task<UpdatedUniversityResponse> Update(UpdateUniversityRequest updateUniversityRequest);
        Task<DeletedUniversityResponse> Delete(DeleteUniversityRequest deleteUniversityRequest);
        Task<IPaginate<GetListUniversityResponse>> GetListUniversity(PageRequest pageRequest);
    }
}
