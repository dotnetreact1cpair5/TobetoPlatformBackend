using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request.CreateRequest;
using Business.Dtos.Request.DeleteRequest;
using Business.Dtos.Request.UpdateRequest;
using Business.Dtos.Response.CreatedResponse;
using Business.Dtos.Response.DeletedResponse;
using Business.Dtos.Response.GetListResponse;
using Business.Dtos.Response.UpdatedResponse;
using Core.DataAccess.Paging;
using Core.Entities.Concrete;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OperationClaimManager : IOperationClaimService
    {

        IOperationClaimDal _operationClaimDal;
        IMapper _mapper;
        public OperationClaimManager(IOperationClaimDal operationClaimDal, IMapper mapper)
        {
            _operationClaimDal = operationClaimDal;
            _mapper = mapper;
        }

        public async Task<CreatedOperationClaimResponse> Add(CreateOperationClaimRequest createOperationClaimRequest)
        {
            OperationClaim operationClaim = _mapper.Map<OperationClaim>(createOperationClaimRequest);
            var createdOperationClaim = await _operationClaimDal.AddAsync(operationClaim);
            CreatedOperationClaimResponse result = _mapper.Map<CreatedOperationClaimResponse>(createdOperationClaim);
            return result;
        }

        public async Task<DeletedOperationClaimResponse> Delete(DeleteOperationClaimRequest deleteOperationClaimRequest)
        {
            OperationClaim operationClaim = await _operationClaimDal.GetAsync(predicate: a => a.Id == deleteOperationClaimRequest.Id);
            var deletedOperationClaim = await _operationClaimDal.DeleteAsync(operationClaim, false);
            DeletedOperationClaimResponse result = _mapper.Map<DeletedOperationClaimResponse>(deletedOperationClaim);
            return result;
        }

        public async Task<GetListOperationClaimResponse> GetById(int operationClaimId)
        {
            var operationClaim = await _operationClaimDal.GetAsync(predicate: a => a.Id == operationClaimId);
            var result = _mapper.Map<GetListOperationClaimResponse>(operationClaim);
            return result;
        }

        public async Task<IPaginate<GetListOperationClaimResponse>> GetListOperationClaim()
        {
            var operationClaim = await _operationClaimDal.GetListAsync();
            var result = _mapper.Map<Paginate<GetListOperationClaimResponse>>(operationClaim);
            return result;
        }

        public async Task<UpdatedOperationClaimResponse> Update(UpdateOperationClaimRequest updateOperationClaimRequest)
        {
            OperationClaim operationClaim = _mapper.Map<OperationClaim>(updateOperationClaimRequest);
            var updatedOperationClaim = await _operationClaimDal.UpdateAsync(operationClaim);
            UpdatedOperationClaimResponse result = _mapper.Map<UpdatedOperationClaimResponse>(updatedOperationClaim);
            return result;
        }

    }



}
