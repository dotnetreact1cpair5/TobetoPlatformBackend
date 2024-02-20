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
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ApplicationManager : IApplicationService
    {
        IApplicationDal _applicationDal;
        IMapper _mapper;
        //ApplicationBusinessRules _applicationBusinessRules;

        public ApplicationManager(IApplicationDal applicationDal,
        IMapper mapper)
        {
            _applicationDal = applicationDal;
            _mapper = mapper;
            //_applicationBusinessRules = applicationBusinessRules;
        }

        public async Task<CreatedApplicationResponse> Add(CreateApplicationRequest createApplicationRequest)
        {
            Application application = _mapper.Map<Application>(createApplicationRequest);
            var createdApplication = await _applicationDal.AddAsync(application);
            CreatedApplicationResponse result = _mapper.Map<CreatedApplicationResponse>(createdApplication);
            return result;
        }

        public async Task<DeletedApplicationResponse> Delete(DeleteApplicationRequest deleteApplicationRequest)
        {
            Application application = _mapper.Map<Application>(deleteApplicationRequest);
            var deletedApplication = await _applicationDal.DeleteAsync(application, false);
            DeletedApplicationResponse result = _mapper.Map<DeletedApplicationResponse>(deletedApplication);
            return result;
        }

        public async Task<IPaginate<GetListApplicationResponse>> GetByUserId(int userId)
        {
            var application = await _applicationDal.GetListAsync(predicate: c => c.UserId == userId,
                 include: c => c.Include(c => c.User)
                 .Include(c=>c.ApplicationStep)
                 .Include(c=>c.Organization)
                 );
            var result = _mapper.Map<Paginate<GetListApplicationResponse>>(application);
            return result;
        }

        public async Task<IPaginate<GetListApplicationResponse>> GetListApplication(PageRequest pageRequest)
        {
            var application = await _applicationDal.GetListAsync(
              include: c => c.Include(c => c.User)
                 .Include(c => c.ApplicationStep)
                 .Include(c => c.Organization),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListApplicationResponse>>(application);
            return result;
        }

        public async Task<UpdatedApplicationResponse> Update(UpdateApplicationRequest updateApplicationRequest)
        {
            Application application = _mapper.Map<Application>(updateApplicationRequest);
            var updatedApplication = await _applicationDal.UpdateAsync(application);
            UpdatedApplicationResponse result = _mapper.Map<UpdatedApplicationResponse>(updatedApplication);
            return result;
        }
    }
}
