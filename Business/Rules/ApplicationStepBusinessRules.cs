using Core.Business.Rules;
using DataAccess.Abstracts;

namespace Business.Rules
{
    public class ApplicationStepBusinessRules:BaseBusinessRules
    {
        private readonly IApplicationStepDal _applicationStepDal;
        public ApplicationStepBusinessRules(IApplicationStepDal applicationStepDal)
        {
            _applicationStepDal = applicationStepDal;
        }
    }
}
