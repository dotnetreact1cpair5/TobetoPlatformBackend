using Business.Constants.Messages;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules
{
    public class AccountApplicationBusinessRules:BaseBusinessRules
    {
        private readonly IAccountApplicationDal _accountApplicationDal;
        public AccountApplicationBusinessRules(IAccountApplicationDal accountApplicationDal)
        {
            _accountApplicationDal = accountApplicationDal;
        }

        public async Task AccountApplicationNotEmpty(int accountId,int applicationId,int applicationStepId)
        {
            if (accountId==0 || applicationId==0 || applicationStepId == 0)
            {
                throw new BusinessException(BusinessMessages.AccountApplicationCannotBeEmpty);
            }
        }
    }
}
