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
    public interface IStudentClassService
    {
        Task<CreatedStudentClassResponse> Add(CreateStudentClassRequest createStudentClassRequest);
        Task<IPaginate<GetListStudentClassResponse>> GetListStudentClass();
        Task<UpdatedStudentClassResponse> Update(UpdateStudentClassRequest updateStudentClassRequest);
        Task<DeletedStudentClassResponse> Delete(DeleteStudentClassRequest deleteStudentClassRequest);
    }
}
