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
    public interface ISocialMediaPlatformService
    {
        Task<IPaginate<GetListSocialMediaPlatformResponse>> GetListSocialMediaPlatform(PageRequest pageRequest);
        Task<CreatedSocialMediaPlatformResponse> Add(CreateSocialMediaPlatformRequest createSocialMediaPlatformRequest);
        Task<UpdatedSocialMediaPlatformResponse> Update(UpdateSocialMediaPlatformRequest updateSocialMediaPlatformRequest);
        Task<DeletedSocialMediaPlatformResponse> Delete(DeleteSocialMediaPlatformRequest deleteSocialMediaPlatformRequest);
    }
}
