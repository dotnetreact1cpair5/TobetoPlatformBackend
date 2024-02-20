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
    public class LessonBusinessRules : BaseBusinessRules
    {
        private readonly ILessonDal _lessonDal;
        public LessonBusinessRules(ILessonDal lessonDal)
        {
            _lessonDal = lessonDal;
        }

        public async Task CheckIfLessonNameExists(string lessonName)
        {
            var result = await _lessonDal.GetListAsync(c => c.Name == lessonName);
            if (result.Count > 0)
            {
                throw new BusinessException(BusinessMessages.SameLessonNameError);
            }
        }
    }



}
