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
    public class SocialMediaPlatformBusinessRules : BaseBusinessRules
    {
        private readonly ISocialMediaPlatformDal _socialMediaPlatformDal;
        public SocialMediaPlatformBusinessRules(ISocialMediaPlatformDal socialMediaPlatformDal)
        {
            _socialMediaPlatformDal = socialMediaPlatformDal;
        }

        public async Task SameSocialMediaName(string name)
        {
            var result = await _socialMediaPlatformDal.GetListAsync(s => s.Name == name);
            if (result.Count > 0)
            {
                throw new BusinessException(BusinessMessages.SameSocialMediaNameError);
            }
        }
    }
}
