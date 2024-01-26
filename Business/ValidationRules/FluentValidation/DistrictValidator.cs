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
    public class DistrictValidator:AbstractValidator<CreateDistrictRequest>
    {
        public DistrictValidator()
        {
            RuleFor(d => d.Name).NotEmpty().WithMessage(BusinessMessages.RequiredField);
        }
    }
}
