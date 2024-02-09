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
    public class OrganizationManager : IOrganizationService
    {
        IOrganizationDal _organizationDal;
        IMapper _mapper;
        OrganizationBusinessRules _organizationBusinessRules;

        public OrganizationManager(IOrganizationDal organizationDal, IMapper mapper, OrganizationBusinessRules organizationBusinessRules)
        {
            _organizationDal = organizationDal;
            _mapper = mapper;
            _organizationBusinessRules = organizationBusinessRules;
        }

        public async Task<CreatedOrganizationResponse> Add(CreateOrganizationRequest createOrganizationRequest)
        {
            await _organizationBusinessRules.CheckIfOrganizationNameExists(createOrganizationRequest.Name);
            Organization organization = _mapper.Map<Organization>(createOrganizationRequest);
            var createdOrganization = await _organizationDal.AddAsync(organization);
            CreatedOrganizationResponse result = _mapper.Map<CreatedOrganizationResponse>(createdOrganization);
            return result;
        }

        public async Task<DeletedOrganizationResponse> Delete(DeleteOrganizationRequest deleteOrganizationRequest)
        {
            Organization organization = await _organizationDal.GetAsync(predicate: a => a.Id == deleteOrganizationRequest.Id);
            var deletedOrganization = await _organizationDal.DeleteAsync(organization, false);
            DeletedOrganizationResponse result = _mapper.Map<DeletedOrganizationResponse>(deletedOrganization);
            return result;
        }

        public async Task<IPaginate<GetListOrganizationResponse>> GetListOrganization(PageRequest pageRequest)
        {
            var organization = await _organizationDal.GetListAsync(include:o=>o.Include(o=>o.City)
                .Include(o=>o.District).Include(o=>o.Country),
                orderBy: o => o.OrderBy(o => o.Id),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListOrganizationResponse>>(organization);
            return result;
        }

        public async Task<UpdatedOrganizationResponse> Update(UpdateOrganizationRequest updateOrganizationRequest)
        {
            await _organizationBusinessRules.CheckIfOrganizationNameExists(updateOrganizationRequest.Name);
            Organization organization = _mapper.Map<Organization>(updateOrganizationRequest);
            var updatedOrganization = await _organizationDal.UpdateAsync(organization);
            UpdatedOrganizationResponse result = _mapper.Map<UpdatedOrganizationResponse>(updatedOrganization);
            return result;
        }
    }
}
