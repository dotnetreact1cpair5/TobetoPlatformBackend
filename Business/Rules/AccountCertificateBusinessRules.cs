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
    public class AccountCertificateBusinessRules : BaseBusinessRules
    {
        private readonly IAccountCertificateDal _accountCertificateDal;
        private readonly IAccountDal _accountDal;

        public AccountCertificateBusinessRules(IAccountCertificateDal accountCertificateDal, IAccountDal accountDal)
        {
            _accountCertificateDal = accountCertificateDal;
            _accountDal = accountDal;
        }

        public async Task RequiredFileFormats(string fileName)
        {
            string extension = Path.GetExtension(fileName);
            string[] fileFormatArr = { ".jpeg", ".png", ".pdf" };

            if (!fileFormatArr.Contains(extension))
            {
                throw new BusinessException(BusinessMessages.FileFormatControl);
            }
        }

        public async Task FileNameCantBeNull(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                throw new BusinessException(BusinessMessages.NotNullableFileName);
            }
        }

        public async Task FileNameIsTooLong(string fileName)
        {
            if (fileName.Length > 255)
            {
                throw new BusinessException(BusinessMessages.TooLongFileName);
            }
        }

        public async Task NotValidCharacters(string fileName)
        {
            string chars = @"[<>:""/\\|?*]";
            if (Regex.IsMatch(fileName, chars))
            {
                throw new BusinessException(BusinessMessages.NotValidCharactersInFileName);
            }
        }

        public async Task MustBeAccountDefined(int accountId)
        {
            var result = await _accountDal.GetListAsync(
                predicate: p => p.Id == accountId
                );
            if (result.Count == 0)
            {
                throw new BusinessException(BusinessMessages.RequiredAccountForCertificate);
            }
        }
    }
}
