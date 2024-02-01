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
    public interface IContentTypeService
    {
        Task<CreatedContentTypeResponse> Add(CreateContentTypeRequest contentTypeRequest);
        Task<IPaginate<GetListContentTypeResponse>> GetListCourseContentType(PageRequest pageRequest);
        Task<UpdatedContentTypeResponse> Update(UpdateContentTypeRequest contentTypeRequest);
        Task<DeletedContentTypeResponse> Delete(DeleteContentTypeRequest courseContentTypeRequest);
    }
}
