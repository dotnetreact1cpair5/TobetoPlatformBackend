using Business.Constants.Messages;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;
using DataAccess.Concretes;

namespace Business.Rules
{
    public class SurveyBusinessRules:BaseBusinessRules
    {
        private readonly ISurveyDal _surveyDal;
        public SurveyBusinessRules(ISurveyDal surveyDal)
        {
            _surveyDal = surveyDal;
        }

        public async Task CheckIfSurveyLinkExists(string surveyLink)
        {
            var result = await _surveyDal.GetListAsync(c => c.Link == surveyLink);
            if (result.Count > 0)
            {
                throw new BusinessException(BusinessMessages.SameSurveyLinkError);
            }
        }

    }
}
