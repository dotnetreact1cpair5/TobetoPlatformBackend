using Core.Business.Rules;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class EducationStatusBusinessRules:BaseBusinessRules
    {
        private readonly IEducationStatusDal _educationStatusDal;
        public EducationStatusBusinessRules(IEducationStatusDal educationStatusDal) 
        {
            _educationStatusDal = educationStatusDal;
        }

        public async Task Rule1()
        {

        }

        public async Task Rule2()
        {

        }
    }
}
