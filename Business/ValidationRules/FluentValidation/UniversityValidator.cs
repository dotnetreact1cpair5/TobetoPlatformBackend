using Business.Constants.Messages;
using Business.Dtos.Request;
using Core.Entities;
using Entities.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UniversityValidator:AbstractValidator<CreateUniversityRequest>
    {
        public UniversityValidator()
        {
            RuleFor(u => u.Name)
                .NotEmpty().WithMessage(BusinessMessages.RequiredField);
            RuleFor(u=>u.Name).MinimumLength(2).WithMessage(BusinessMessages.MinLengthError2);
            RuleFor(u=>u.Name).MaximumLength(50).WithMessage(BusinessMessages.MaxLengthError50);
        }
    }
}
