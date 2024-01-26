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
    public class CityValidator:AbstractValidator<CreateCityRequest>
    {
        public CityValidator()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage(BusinessMessages.RequiredField);
            RuleFor(c => c.Name).MinimumLength(2).WithMessage(BusinessMessages.MinLengthError2);
            RuleFor(c => c.Name).MaximumLength(30).WithMessage(BusinessMessages.MaxLengthError30);
        }
    }
}


