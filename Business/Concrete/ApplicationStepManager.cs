using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request.CreateRequest;
using Business.Dtos.Request.DeleteRequest;
using Business.Dtos.Request.UpdateRequest;
using Business.Dtos.Response.CreatedResponse;
using Business.Dtos.Response.DeletedResponse;
using Business.Dtos.Response.GetListResponse;
using Business.Dtos.Response.UpdatedResponse;
using Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;

namespace Business.Concrete
{
    public class ApplicationStepManager : IApplicationStepService
    {
        IApplicationStepDal _applicationStepDal;
        IMapper _mapper;
        //ApplicationBusinessRules _applicationBusinessRules;

        public ApplicationStepManager(IApplicationStepDal applicationStepDal,
        IMapper mapper)
        {
            _applicationStepDal = applicationStepDal;
            _mapper = mapper;
            //_applicationBusinessRules = applicationBusinessRules;
        }

        public async Task<CreatedApplicationStepResponse> Add(CreateApplicationStepRequest createApplicationStepRequest)
        {
            ApplicationStep applicationStep = _mapper.Map<ApplicationStep>(createApplicationStepRequest);
            var createdApplicationStep = await _applicationStepDal.AddAsync(applicationStep);
            CreatedApplicationStepResponse result = _mapper.Map<CreatedApplicationStepResponse>(createdApplicationStep);
            return result;
        }

        public async Task<DeletedApplicationStepResponse> Delete(DeleteApplicationStepRequest deleteApplicationStepRequest)
        {
            ApplicationStep applicationStep = _mapper.Map<ApplicationStep>(deleteApplicationStepRequest);
            var deletedApplicationStep = await _applicationStepDal.DeleteAsync(applicationStep,false);
            DeletedApplicationStepResponse result = _mapper.Map<DeletedApplicationStepResponse>(deletedApplicationStep);
            return result;
        }

        public async Task<IPaginate<GetListApplicationStepResponse>> GetListApplicationStep(PageRequest pageRequest)
        {
            var applicationStep = await _applicationStepDal.GetListAsync(
                orderBy: a => a.OrderBy(a => a.Id),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListApplicationStepResponse>>(applicationStep);
            return result;
        }

        public async Task<UpdatedApplicationStepResponse> Update(UpdateApplicationStepRequest updateApplicationStepRequest)
        {
            ApplicationStep applicationStep = _mapper.Map<ApplicationStep>(updateApplicationStepRequest);
            var updatedApplicationStep = await _applicationStepDal.UpdateAsync(applicationStep);
            UpdatedApplicationStepResponse result = _mapper.Map<UpdatedApplicationStepResponse>(updatedApplicationStep);
            return result;
        }
    }
}
