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
    public class CoursePageBusinessRules : BaseBusinessRules
    {
        private readonly ICoursePageDal _coursePageDal;
        public CoursePageBusinessRules(ICoursePageDal coursePageDal)
        {
            _coursePageDal = coursePageDal;
        }

        public async Task CheckIfCoursePageNameExists(string coursePageName)
        {
            var result = await _coursePageDal.GetListAsync(c => c.Name == coursePageName);
            if (result.Count > 0)
            {
                throw new BusinessException(BusinessMessages.SameCoursePageNameError);
            }
        }
    }



}
