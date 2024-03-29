﻿using Business.Dtos.Request;
using Business.Dtos.Request.CreateRequest;
using Business.Dtos.Request.DeleteRequest;
using Business.Dtos.Request.UpdateRequest;
using Business.Dtos.Response.CreatedResponse;
using Business.Dtos.Response.DeletedResponse;
using Business.Dtos.Response.GetListResponse;
using Business.Dtos.Response.UpdatedResponse;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAccountSocialMediaService
    {
        Task<IPaginate<GetListAccountSocialMediaResponse>> GetListAccountSocialMedia(PageRequest pageRequest);
        Task<CreatedAccountSocialMediaResponse> Add(CreateAccountSocialMediaRequest createAccountSocialMediaRequest);
        Task<UpdatedAccountSocialMediaResponse> Update(UpdateAccountSocialMediaRequest updateAccountSocialMediaRequest);
        Task<DeletedAccountSocialMediaResponse> Delete(DeleteAccountSocialMediaRequest deleteAccountSocialMediaRequest);
    }
}
