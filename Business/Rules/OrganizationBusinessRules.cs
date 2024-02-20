using Core.Business.Rules;
using Business.Constants.Messages;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class OrganizationBusinessRules : BaseBusinessRules
    {
        private readonly IOrganizationDal _organizationDal;
        public OrganizationBusinessRules(IOrganizationDal organizationDal)
        {
            _organizationDal = organizationDal;
        }

        public async Task CheckIfOrganizationNameExists(string organizationName)
        {
            var result = await _organizationDal.GetListAsync(c => c.Name == organizationName);
            if (result.Count > 0)
            {
                throw new BusinessException(BusinessMessages.SameOrganizationNameError);
            }
        }
    }

}
