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
    public interface ICourseFavouriteService
    {
        Task<CreatedCourseFavouriteResponse> Add(CreateCourseFavouriteRequest createCourseFavouriteRequest);
        Task<IPaginate<GetListCourseFavouriteResponse>> GetListCourseFavourite();
        Task<UpdatedCourseFavouriteResponse> Update(UpdateCourseFavouriteRequest updateCourseFavouriteRequest);
        Task<DeletedCourseFavouriteResponse> Delete(DeleteCourseFavouriteRequest deleteCourseFavouriteRequest);
        Task<GetListCourseFavouriteResponse> GetById(int accountCourseFavouriteId);
    }

}
