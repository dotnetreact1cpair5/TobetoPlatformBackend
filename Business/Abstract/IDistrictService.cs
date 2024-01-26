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
    public interface IDistrictService
    {
        Task<CreatedDistrictResponse> Add(CreateDistrictRequest createDistrictRequest);

        Task<IPaginate<GetListDistrictResponse>> GetDistrictListAsync(PageRequest pageRequest);

        Task<UpdatedDistrictResponse> Update(UpdateDistrictRequest updateDistrictRequest);

        Task<DeletedDistrictResponse> Delete(DeleteDistrictRequest deleteDistrictRequest);
    }
}
