using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Business.Rules;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EducationStatusManager : IEducationStatusService
    {
        IEducationStatusDal _educationStatusDal;
        IMapper _mapper;
        //EducationStatusBusinessRules _educationStatusBusinessRules;

        public EducationStatusManager(IEducationStatusDal educationStatusDal,
        IMapper mapper)
        {
            _educationStatusDal = educationStatusDal;
            _mapper = mapper;
            //_educationStatusBusinessRules = educationStatusBusinessRules;
        }

        [ValidationAspect(typeof(EducationStatusValidator))]
        public async Task<CreatedEducationStatusResponse> Add(CreateEducationStatusRequest createEducationStatusRequest)
        {
            EducationStatus educationStatus = _mapper.Map<EducationStatus>(createEducationStatusRequest);
            var createdEducationStatus = await _educationStatusDal.AddAsync(educationStatus);
            CreatedEducationStatusResponse result = _mapper.Map<CreatedEducationStatusResponse>(createdEducationStatus);
            return result;
        }

        public async Task<DeletedEducationStatusResponse> Delete(DeleteEducationStatusRequest deleteEducationStatusRequest)
        {
            EducationStatus educationStatus = _mapper.Map<EducationStatus>(deleteEducationStatusRequest);
            var deletedEducationStatus = await _educationStatusDal.DeleteAsync(educationStatus, false);
            DeletedEducationStatusResponse result = _mapper.Map<DeletedEducationStatusResponse>(deletedEducationStatus);
            return result;
        }

        public async Task<IPaginate<GetListEducationStatusResponse>> GetListEducationStatus(PageRequest pageRequest)
        {
            var educationStatus = await _educationStatusDal.GetListAsync(
                orderBy: e => e.OrderBy(e => e.Id),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListEducationStatusResponse>>(educationStatus);
            return result;
        }

        public async Task<UpdatedEducationStatusResponse> Update(UpdateEducationStatusRequest updateEducationStatusRequest)
        {
            EducationStatus educationStatus = _mapper.Map<EducationStatus>(updateEducationStatusRequest);
            var updatedEducationStatus = await _educationStatusDal.UpdateAsync(educationStatus);
            UpdatedEducationStatusResponse result = _mapper.Map<UpdatedEducationStatusResponse>(updatedEducationStatus);
            return result;
        }
    }
}
