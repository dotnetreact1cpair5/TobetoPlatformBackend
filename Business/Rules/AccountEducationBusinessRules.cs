using Business.Constants.Messages;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules
{
    public class AccountEducationBusinessRules:BaseBusinessRules
    {
        private readonly IAccountEducationDal _accountEducationDal;
        public AccountEducationBusinessRules(IAccountEducationDal accountEducationDal)
        {
            _accountEducationDal = accountEducationDal;
        }

        public async Task AccountEducationNotEmpty(int accountId, int educationStatusId, int universityId,int educationProgramId)
        {
            if (accountId == 0 || educationStatusId == 0 || universityId == 0 || educationProgramId == 0)
            {
                throw new BusinessException(BusinessMessages.AccountEducationCannotBeEmpty);
            }
        }
    }
}
