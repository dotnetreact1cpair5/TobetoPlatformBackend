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
    public interface ICourseService
    {
        Task<CreatedCourseResponse> Add(CreateCourseRequest createCourseRequest);
        Task<IPaginate<GetListCourseResponse>> GetListCourse();
        Task<UpdatedCourseResponse> Update(UpdateCourseRequest updateCourseRequest);
        Task<DeletedCourseResponse> Delete(DeleteCourseRequest deleteCourseRequest);
    }
}
