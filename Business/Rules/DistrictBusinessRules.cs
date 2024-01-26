using Core.Business.Rules;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class DistrictBusinessRules:BaseBusinessRules
    {
        private readonly IDistrictDal _districtDal;

        public DistrictBusinessRules(IDistrictDal districtDal)
        {
            _districtDal = districtDal;
        }

        public async Task Rule1()
        {

        }
    }
}
