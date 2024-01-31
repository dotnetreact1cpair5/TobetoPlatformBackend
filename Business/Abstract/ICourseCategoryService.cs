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
    public interface ICourseCategoryService
    {
        Task<CreatedCategoryResponse> Add(CreateCategoryRequest createCourseCategoryRequest);
        Task<IPaginate<GetListCategoryResponse>> GetListCourseCategory();
        Task<UpdatedCategoryResponse> Update(UpdateCategoryRequest updateCourseCategoryRequest);
        Task<DeletedCategoryResponse> Delete(DeleteCategoryRequest deleteCourseCategoryRequest);
    }
}
