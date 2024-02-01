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
    public class CourseCategoryBusinessRules : BaseBusinessRules
    {
        private readonly ICourseCategoryDal _courseCategoryDal;
        public CourseCategoryBusinessRules(ICourseCategoryDal courseCategoryDal)
        {
            _courseCategoryDal = courseCategoryDal;
        }

        public async Task CheckIfCourseCategoryNameExists(string courseCategoryName)
        {
            var result = await _courseCategoryDal.GetListAsync(c => c.Name == courseCategoryName);
            if (result.Count > 0)
            {
                throw new BusinessException(BusinessMessages.SameCourseCategoryNameError);
            }
        }
    }



}
