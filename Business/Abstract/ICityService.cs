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
    public interface ICityService
    {
        Task<CreatedCityResponse> Add(CreateCityRequest createCityRequest);

        Task<IPaginate<GetListCityResponse>> GetCityListAsync(PageRequest pageRequest);

        Task<UpdatedCityResponse> Update(UpdateCityRequest updateCityRequest);

        Task<DeletedCityResponse> Delete(DeleteCityRequest deleteCityRequest);
    }
}
