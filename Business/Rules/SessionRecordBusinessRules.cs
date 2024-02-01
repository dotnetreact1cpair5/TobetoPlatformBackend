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
    public class SessionRecordBusinessRules : BaseBusinessRules
    {
        private readonly ISessionRecordDal _sessionRecordDal;
        public SessionRecordBusinessRules(ISessionRecordDal sessionRecordDal)
        {
            _sessionRecordDal = sessionRecordDal;
        }

        public async Task CheckIfSessionRecordNameExists(string sessionRecordName)
        {
            var result = await _sessionRecordDal.GetListAsync(c => c.Name == sessionRecordName);
            if (result.Count > 0)
            {
                throw new BusinessException(BusinessMessages.SameSessionRecordNameError);
            }
        }
    }



}
