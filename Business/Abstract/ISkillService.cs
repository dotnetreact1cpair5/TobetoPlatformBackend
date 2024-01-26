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
    public interface ISkillService
    {
        Task<IPaginate<GetListSkillResponse>> GetListSkillInformation(PageRequest pageRequest);
        Task<CreatedSkillResponse> Add(CreateSkillRequest createSkillRequest);
        Task<UpdatedSkillResponse> Update(UpdateSkillRequest updateSkillsRequest);
        Task<DeletedSkillResponse> Delete(DeleteSkillRequest deleteSkillsRequest);
    }
}
