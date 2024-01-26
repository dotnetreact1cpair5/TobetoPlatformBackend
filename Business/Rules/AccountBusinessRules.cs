using Business.Constants.Messages;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class AccountBusinessRules :BaseBusinessRules
    {
        private readonly IAccountDal _accountDal;

        public AccountBusinessRules(IAccountDal accountDal)
        {
            _accountDal = accountDal;
        }

        public async Task MaxNationalIdLength(string nationalId)
        {
            if (!nationalId.All(char.IsDigit))
            {
                throw new BusinessException("Tc sadece rakam içermelidir.");
            }

            if (nationalId.Length != 11)
            {
                throw new BusinessException("Tc 11 haneli olmalıdır.");
            }

            var result = await _accountDal.GetListAsync(a => a.NationalId == nationalId);
            if (result.Count > 0)
            {
                throw new BusinessException("Bu Tc kimlik numarası zaten kullanımda.");
            }
        }

        public async Task MailFormat(string mail)
        {
            var paginatedResult = await _accountDal.GetListAsync(a => a.Email == mail);

            if (paginatedResult.Count > 0)
            {
                throw new BusinessException("Bu e-posta adresi zaten kullanımda.");
            }

            string emailPattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            bool isValidEmail = Regex.IsMatch(mail, emailPattern);

            if (!isValidEmail)
            {
                throw new BusinessException("Geçersiz e-posta formatı.");
            }
        }

    }
}
