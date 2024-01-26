using Business.Constants.Messages;
using Business.Dtos.Request;
using Entities.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class EducationProgramValidator : AbstractValidator<CreateEducationProgramRequest>
    {
        public EducationProgramValidator()
        {
            RuleFor(e => e.Name)
                .NotEmpty().WithMessage(BusinessMessages.RequiredField);
            RuleFor(e => e.Name).MinimumLength(2).WithMessage(BusinessMessages.MinLengthError2);
            RuleFor(e => e.Name).MaximumLength(50).WithMessage(BusinessMessages.MaxLengthError50);
        }
    }
}
