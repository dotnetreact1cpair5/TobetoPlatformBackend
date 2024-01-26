using Core.Business.Rules;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class AccountSkillBusinessRules : BaseBusinessRules
    {
        IAccountSkillDal _accountSkillDal;

        public AccountSkillBusinessRules(IAccountSkillDal accountSkillDal)
        {
            _accountSkillDal = accountSkillDal;
        }

        public async Task SameAccountSkillName(string name)
        {
            
        }
    }
}
