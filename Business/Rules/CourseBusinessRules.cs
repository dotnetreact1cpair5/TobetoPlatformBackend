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
    public class CourseBusinessRules : BaseBusinessRules
    {
        private readonly ICourseDal _courseDal;
        public CourseBusinessRules(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public async Task CheckIfCourseNameExists(string courseName)
        {
            var result = await _courseDal.GetListAsync(c => c.Name == courseName);
            if (result.Count > 0)
            {
                throw new BusinessException(BusinessMessages.SameCourseNameError);
            }
        }
    }



}
