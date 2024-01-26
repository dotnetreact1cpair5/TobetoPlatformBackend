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
    public interface IEducationStatusService
    {
        Task<CreatedEducationStatusResponse> Add(CreateEducationStatusRequest createEducationStatusRequest);
        Task<UpdatedEducationStatusResponse> Update(UpdateEducationStatusRequest updateEducationStatusRequest);
        Task<DeletedEducationStatusResponse> Delete(DeleteEducationStatusRequest deleteEducationStatusRequest);
        Task<IPaginate<GetListEducationStatusResponse>> GetListEducationStatus(PageRequest pageRequest); 
    }
}
