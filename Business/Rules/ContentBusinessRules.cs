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
    public class ContentBusinessRules : BaseBusinessRules
    {
        private readonly IContentDal _contentDal;
        public ContentBusinessRules(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }

        public async Task CheckIfContentNameExists(string contentName)
        {
            var result = await _contentDal.GetListAsync(c => c.Name == contentName);
            if (result.Count > 0)
            {
                throw new BusinessException(BusinessMessages.SameContentNameError);
            }
        }
    }


}
