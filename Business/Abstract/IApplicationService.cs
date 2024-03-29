﻿using Business.Dtos.Request.CreateRequest;
using Business.Dtos.Request.DeleteRequest;
using Business.Dtos.Request.UpdateRequest;
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
    public interface IApplicationService
    {
        Task<CreatedApplicationResponse> Add(CreateApplicationRequest createApplicationRequest);
        Task<UpdatedApplicationResponse> Update(UpdateApplicationRequest updateApplicationRequest);
        Task<DeletedApplicationResponse> Delete(DeleteApplicationRequest deleteApplicationRequest);
        Task<IPaginate<GetListApplicationResponse>> GetListApplication(PageRequest pageRequest);
        Task<IPaginate<GetListApplicationResponse>> GetByUserId(int userId);
    }
}
