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
    public class ContentTypeBusinessRules : BaseBusinessRules
    {
        private readonly IContentTypeDal _contentTypeDal;
        public ContentTypeBusinessRules(IContentTypeDal contentTypeDal)
        {
            _contentTypeDal = contentTypeDal;
        }

        public async Task CheckIfContentTypeNameExists(string contentTypeName)
        {
            var result = await _contentTypeDal.GetListAsync(c => c.Name == contentTypeName);
            if (result.Count > 0)
            {
                throw new BusinessException(BusinessMessages.SameContentTypeNameError);
            }
        }
    }



}
