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
    public class CityManager : ICityService
    {
        ICityDal _cityDal;
        IMapper _mapper;
        CityBusinessRules _cityBusinessRules;

        public CityManager(ICityDal cityDal, IMapper mapper, CityBusinessRules cityBusinessRules)
        {
            _cityDal = cityDal;
            _mapper = mapper;
            _cityBusinessRules = cityBusinessRules;
        }

        [ValidationAspect(typeof(CityValidator))]
        public async Task<CreatedCityResponse> Add(CreateCityRequest createCityRequest)
        {
            await _cityBusinessRules.SameCityName(createCityRequest.Name, createCityRequest.CountryId);
            City city = _mapper.Map<City>(createCityRequest);
            var createdCity = await _cityDal.AddAsync(city);
            CreatedCityResponse result = _mapper.Map<CreatedCityResponse>(createdCity);
            return result;
        }

        public async Task<DeletedCityResponse> Delete(DeleteCityRequest deleteCityRequest)
        {
            City city = await _cityDal.GetAsync(d => d.Id == deleteCityRequest.Id);
            var deletedCity = await _cityDal.DeleteAsync(city, false);
            DeletedCityResponse result = _mapper.Map<DeletedCityResponse>(deletedCity);
            return result;
        }

        public async Task<IPaginate<GetListCityResponse>> GetCityListAsync(PageRequest pageRequest)
        {
            var cities = await _cityDal.GetListAsync(
                orderBy: c => c.OrderBy(c => c.Id),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListCityResponse>>(cities);
            return result;
        }

        public async Task<UpdatedCityResponse> Update(UpdateCityRequest updateCityRequest)
        {
            City city = await _cityDal.GetAsync(i => i.Id == updateCityRequest.Id);
            _mapper.Map(updateCityRequest, city);
            var updatedCity = await _cityDal.UpdateAsync(city);
            UpdatedCityResponse result = _mapper.Map<UpdatedCityResponse>(updatedCity);
            return result;
        }
    }
}
