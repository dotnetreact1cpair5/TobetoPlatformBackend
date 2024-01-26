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
    public class CountryBusinessRules : BaseBusinessRules
    {
        private readonly ICountryDal _countryDal;
        public CountryBusinessRules(ICountryDal countryDal)
        {
            _countryDal = countryDal;
        }

        public async Task SameCountryName(string name)
        {
            var result = await _countryDal.GetListAsync(c => c.Name == name);
            if (result.Count > 0)
            {
                throw new BusinessException(BusinessMessages.SameCountryNameError);
            }
        }

        public async Task SameCountryCode(string code)
        {
            var result = await _countryDal.GetListAsync(c=>c.Code==code);
            if (result.Count>0)
            {
                throw new BusinessException(BusinessMessages.SameCountryCodeError);
            }
        }
    }
}
