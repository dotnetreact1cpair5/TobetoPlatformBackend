using Business.Constants.Messages;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using DataAccess.Concretes;

namespace Business.Rules
{
    public class UniversityBusinessRules : BaseBusinessRules
    {
        private readonly IUniversityDal _universityDal;
        public UniversityBusinessRules(IUniversityDal universityDal)
        {
            _universityDal = universityDal;
        }

        public async Task SameUniversityName(string name)
        {
            var result = await _universityDal.GetListAsync(u => u.Name == name);
            if (result.Count > 0)
            {
                throw new BusinessException(BusinessMessages.SameUniversityNameError);
            }
        }
    }
}
