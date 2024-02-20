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
    public class DistrictManager : IDistrictService
    {
        IDistrictDal _districtDal;
        IMapper _mapper;
        //DistrictBusinessRules _districtBusinessRules;

        public DistrictManager(IDistrictDal districtDal, IMapper mapper)
        {
            _districtDal = districtDal;
            _mapper = mapper;
            //_districtBusinessRules = districtBusinessRules;
        }

        [ValidationAspect(typeof(DistrictValidator))]
        public async Task<CreatedDistrictResponse> Add(CreateDistrictRequest createDistrictRequest)
        {
            //Rule will add
            District district = _mapper.Map<District>(createDistrictRequest);
            var createdDistrict = await _districtDal.AddAsync(district);
            CreatedDistrictResponse result = _mapper.Map<CreatedDistrictResponse>(createdDistrict);
            return result;
        }

        public async Task<DeletedDistrictResponse> Delete(DeleteDistrictRequest deleteDistrictRequest)
        {
            District district = await _districtDal.GetAsync(d => d.Id == deleteDistrictRequest.Id);
            var deletedDistrict = await _districtDal.DeleteAsync(district, false);
            DeletedDistrictResponse result = _mapper.Map<DeletedDistrictResponse>(deletedDistrict);
            return result;
        }

        public async Task<IPaginate<GetListDistrictResponse>> GetDistrictListAsync(PageRequest pageRequest)
        {
            var districts = await _districtDal.GetListAsync(
                orderBy: d => d.OrderBy(d => d.Id),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListDistrictResponse>>(districts);
            return result;
        }

        public async Task<UpdatedDistrictResponse> Update(UpdateDistrictRequest updateDistrictRequest)
        {
            District district = await _districtDal.GetAsync(i => i.Id == updateDistrictRequest.Id);
            _mapper.Map(updateDistrictRequest, district);
            var updatedDistrict = await _districtDal.UpdateAsync(district);
            UpdatedDistrictResponse result = _mapper.Map<UpdatedDistrictResponse>(updatedDistrict);
            return result;
        }
    }
}
