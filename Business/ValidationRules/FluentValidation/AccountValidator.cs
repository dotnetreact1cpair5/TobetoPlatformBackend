using Business.Constants.Messages;
using Business.Dtos.Request.CreateRequest;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class AccountValidator : AbstractValidator<CreateAccountRequest>
    {
        public AccountValidator()
        {
            RuleFor(a => a.FirstName).NotEmpty().WithMessage(BusinessMessages.RequiredField);
            RuleFor(a => a.Email).NotEmpty().WithMessage(BusinessMessages.RequiredField);
            RuleFor(a => a.PhoneNumber).NotEmpty().WithMessage(BusinessMessages.RequiredField);
            RuleFor(a => a.NationalId).NotEmpty().WithMessage(BusinessMessages.RequiredField);
            RuleFor(a => a.LastName).NotEmpty().WithMessage(BusinessMessages.RequiredField);
        }
    }
}
