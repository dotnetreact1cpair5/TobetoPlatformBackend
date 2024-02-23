using Business.Dtos.Request.CreateRequest;
using Business.Dtos.Request.DeleteRequest;
using Business.Dtos.Request.UpdateRequest;
using Business.Dtos.Response;
using Business.Dtos.Response.CreatedResponse;
using Business.Dtos.Response.DeletedResponse;
using Business.Dtos.Response.GetListResponse;
using Business.Dtos.Response.UpdatedResponse;
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
        Task<IPaginate<GetListSkillsResponse>> GetListSkillInformation(PageRequest pageRequest);
        Task<CreatedSkillsResponse> Add(CreateSkillRequest createSkillRequest);
        Task<UpdatedSkillsResponse> Update(UpdateSkillRequest updateSkillsRequest);
        Task<DeletedSkillsResponse> Delete(DeleteSkillRequest deleteSkillsRequest);
    }
}
