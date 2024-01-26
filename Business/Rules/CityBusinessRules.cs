using Business.Constants.Messages;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class CityBusinessRules:BaseBusinessRules
    {
        private readonly ICityDal _cityDal;
        public CityBusinessRules(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public async Task SameCityName(string name, int countryId)
        {
            var result = await _cityDal.GetListAsync(ci => ci.Name == name && ci.CountryId == countryId);
            if (result.Count > 0)
            {
                throw new BusinessException(BusinessMessages.SameCityNameError);
            }
        }
    }
}
