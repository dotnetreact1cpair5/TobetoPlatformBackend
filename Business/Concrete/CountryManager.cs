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
    public class CountryManager : ICountryService
    {
        ICountryDal _countryDal;
        IMapper _mapper;
        CountryBusinessRules _countryBusinessRules;

        public CountryManager(ICountryDal countryDal, IMapper mapper, CountryBusinessRules countryBusinessRules)
        {
            _countryDal = countryDal;
            _mapper = mapper;
            _countryBusinessRules = countryBusinessRules;
        }

        [ValidationAspect(typeof(CountryValidator))]
        public async Task<CreatedCountryResponse> Add(CreateCountryRequest createCountryRequest)
        {
            await _countryBusinessRules.SameCountryName(createCountryRequest.Name);
            await _countryBusinessRules.SameCountryCode(createCountryRequest.Code);
            Country country = _mapper.Map<Country>(createCountryRequest);
            var createdCountry = await _countryDal.AddAsync(country);
            CreatedCountryResponse result = _mapper.Map<CreatedCountryResponse>(createdCountry);
            return result;
        }

        public async Task<DeletedCountryResponse> Delete(DeleteCountryRequest deleteCountryRequest)
        {
            Country country = await _countryDal.GetAsync(d => d.Id == deleteCountryRequest.Id);
            var deletedCountry = await _countryDal.DeleteAsync(country, false);
            DeletedCountryResponse result = _mapper.Map<DeletedCountryResponse>(deletedCountry);
            return result;
        }

        public async Task<IPaginate<GetListCountryResponse>> GetCountryListAsync(PageRequest pageRequest)
        {
            var countries = await _countryDal.GetListAsync(
                orderBy: c => c.OrderBy(c => c.Id),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize);
            var result = _mapper.Map<Paginate<GetListCountryResponse>>(countries);
            return result;

        }

        public async Task<UpdatedCountryResponse> Update(UpdateCountryRequest updateCountryRequest)
        {
            Country country = await _countryDal.GetAsync(i => i.Id == updateCountryRequest.Id);
            _mapper.Map(updateCountryRequest, country);
            var updatedCountry = await _countryDal.UpdateAsync(country);
            UpdatedCountryResponse result = _mapper.Map<UpdatedCountryResponse>(updatedCountry);
            return result;
        }
    }
}
