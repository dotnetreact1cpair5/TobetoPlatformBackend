using AutoMapper;
using Business.Dtos.Request.CreateRequest;
using Business.Dtos.Request.DeleteRequest;
using Business.Dtos.Request.UpdateRequest;
using Business.Dtos.Response.CreatedResponse;
using Business.Dtos.Response.DeletedResponse;
using Business.Dtos.Response.GetListResponse;
using Business.Dtos.Response.UpdatedResponse;
using Core.DataAccess.Paging;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class OperationClaimMappingProfile : Profile
    {
        public OperationClaimMappingProfile()
        {
            CreateMap<CreateOperationClaimRequest, OperationClaim>().ReverseMap();
            CreateMap<UpdateOperationClaimRequest, OperationClaim>().ReverseMap();
            CreateMap<DeleteOperationClaimRequest, OperationClaim>().ReverseMap();

            CreateMap<OperationClaim, GetListOperationClaimResponse>().ReverseMap();
            CreateMap<Paginate<OperationClaim>, Paginate<GetListOperationClaimResponse>>().ReverseMap();

            CreateMap<OperationClaim, CreatedOperationClaimResponse>().ReverseMap();
            CreateMap<OperationClaim, UpdatedOperationClaimResponse>().ReverseMap();
            CreateMap<OperationClaim, DeletedOperationClaimResponse>().ReverseMap();
        }
    }

}
