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
    public interface ICountryService
    {
        Task<CreatedCountryResponse> Add(CreateCountryRequest createCountryRequest);

        Task<IPaginate<GetListCountryResponse>> GetCountryListAsync(PageRequest pageRequest);

        Task<UpdatedCountryResponse> Update(UpdateCountryRequest updateCountryRequest);

        Task<DeletedCountryResponse> Delete(DeleteCountryRequest deleteCountryRequest);
    }
}
