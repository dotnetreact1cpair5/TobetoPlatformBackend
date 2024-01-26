using Business.Constants.Messages;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Results;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Rules
{
    public class AccountSocialMediaBusinessRules:BaseBusinessRules
    {
        private readonly IAccountSocialMediaDal _accountSocialMediaDal;

        public AccountSocialMediaBusinessRules(IAccountSocialMediaDal accountSocialMediaDal)
        {
            _accountSocialMediaDal = accountSocialMediaDal;
        }

        public async Task SameAccountSocialMediaLink(string link)
        {
            var result = await _accountSocialMediaDal.GetListAsync(l => l.Link == link);
            if (result.Count > 0)
            {
                throw new BusinessException(BusinessMessages.SameAccountSocialMediaLinkError);
            }
        }
    }
}
