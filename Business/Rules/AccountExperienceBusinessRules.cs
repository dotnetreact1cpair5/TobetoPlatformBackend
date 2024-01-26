using Business.Constants.Messages;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Entities;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class AccountExperienceBusinessRules : BaseBusinessRules
    {
        private readonly IAccountExperienceDal _accountExperienceDal;

        public AccountExperienceBusinessRules(IAccountExperienceDal accountExperienceDal)
        {
            _accountExperienceDal = accountExperienceDal;
        }

        public async Task AccountExperienceRule()
        {

        }
    }
}
