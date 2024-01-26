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
    public class SkillBusinessRules : BaseBusinessRules
    {
        private readonly ISkillDal _skillDal;

        public SkillBusinessRules(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public async Task SameSkillName(string name)
        {
            var result = await _skillDal.GetListAsync(s => s.Name == name);
            if (result.Count>0)
            {
                throw new BusinessException(BusinessMessages.SameSkillNameError);
            }
        }
    }
}
