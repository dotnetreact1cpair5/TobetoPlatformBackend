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
    public interface IEducationProgramService
    {
        Task<CreatedEducationProgramResponse> Add(CreateEducationProgramRequest createEducationProgramRequest);
        Task<UpdatedEducationProgramResponse> Update(UpdateEducationProgramRequest updateEducationProgramRequest);
        Task<DeletedEducationProgramResponse> Delete(DeleteEducationProgramRequest deleteEducationProgramRequest);
        Task<IPaginate<GetListEducationProgramResponse>> GetListEducationProgram(PageRequest pageRequest);
    }
}
