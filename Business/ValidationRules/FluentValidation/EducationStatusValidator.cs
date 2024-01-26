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
    public class EducationStatusValidator : AbstractValidator<CreateEducationStatusRequest>
    {
        public EducationStatusValidator()
        {
            RuleFor(e => e.Name).NotEmpty().WithMessage(BusinessMessages.RequiredField);
        }
    }
}
