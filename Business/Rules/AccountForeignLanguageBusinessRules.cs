using Core.Business.Rules;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class AccountForeignLanguageBusinessRules : BaseBusinessRules
    {
        private readonly IAccountForeignLanguageDal _accountForeignLanguageDal;

        public AccountForeignLanguageBusinessRules(IAccountForeignLanguageDal accountForeignLanguageDal)
        {
            _accountForeignLanguageDal = accountForeignLanguageDal;
        }

        public async Task Rule1()
        {

        }
        public async Task Rule2()
        {

        }
        public async Task Rule3()
        {

        }
    }
}
