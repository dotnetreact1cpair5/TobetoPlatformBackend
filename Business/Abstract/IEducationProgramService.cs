using Business.Dtos.Request;
using Business.Dtos.Response;
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
