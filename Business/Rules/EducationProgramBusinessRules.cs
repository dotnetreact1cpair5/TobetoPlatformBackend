using Business.Constants.Messages;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using DataAccess.Concretes;

namespace Business.Rules
{
    public class EducationProgramBusinessRules : BaseBusinessRules
    {
        private readonly IEducationProgramDal _educationProgramDal;
        public EducationProgramBusinessRules(IEducationProgramDal educationProgramDal)
        {
            _educationProgramDal = educationProgramDal;
        }

        public async Task SameProgramName(int universityId, string name)
        {
            var result = await _educationProgramDal.GetListAsync(p => p.UniversityId == universityId && p.Name == name);

            if (result.Count > 0)
            {
                throw new BusinessException(BusinessMessages.SameProgramNameError);
            }
        }
    }
}

