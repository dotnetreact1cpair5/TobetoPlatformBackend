using Business.Constants.Messages;
using Business.Dtos.Request;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ForeignLanguageValidator : AbstractValidator<CreateForeignLanguageRequest>
    {
        public ForeignLanguageValidator()
        {
            RuleFor(fl => fl.Name).NotEmpty().WithMessage(BusinessMessages.RequiredField);
        }
    }
}
