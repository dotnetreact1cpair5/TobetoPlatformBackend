using Business.Dtos.Request.CreateRequest;
using Business.Dtos.Request.DeleteRequest;
using Business.Dtos.Request.UpdateRequest;
using Business.Dtos.Response.CreatedResponse;
using Business.Dtos.Response.DeletedResponse;
using Business.Dtos.Response.UpdatedResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPathFileService
    {
        Task<CreatedPathFileResponse> Add(CreatePathFileRequest createPathRequest);
        Task<DeletedPathFileResponse> Delete(DeletePathFileRequest deletePathRequest);
        Task<UpdatedPathFileResponse> Update(UpdatePathFileRequest updatePathRequest);

    }
}
