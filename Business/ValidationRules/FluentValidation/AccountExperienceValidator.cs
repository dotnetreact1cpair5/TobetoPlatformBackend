using Business.Constants.Messages;
using Business.Dtos.Request.CreateRequest;
using Entities.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class AccountExperienceValidator : AbstractValidator<CreateAccountExperienceRequest>
    {
        public AccountExperienceValidator()
        {
            RuleFor(e => e.CompanyName).NotEmpty().WithMessage(BusinessMessages.RequiredField);
            RuleFor(e => e.CompanyName).MinimumLength(5).WithMessage(BusinessMessages.MinLengthError5);
            RuleFor(e => e.CompanyName).MaximumLength(50).WithMessage(BusinessMessages.MaxLengthError50);
            RuleFor(e => e.Position).NotEmpty().WithMessage(BusinessMessages.RequiredField);
            RuleFor(e => e.Position).MinimumLength(5).WithMessage(BusinessMessages.MinLengthError5);
            RuleFor(e => e.Position).MaximumLength(50).WithMessage(BusinessMessages.MaxLengthError50);
            RuleFor(e => e.Sector).NotEmpty().WithMessage(BusinessMessages.RequiredField);
            RuleFor(e => e.Sector).MinimumLength(5).WithMessage(BusinessMessages.MinLengthError5);
            RuleFor(e => e.Sector).MaximumLength(50).WithMessage(BusinessMessages.MaxLengthError50);
            RuleFor(e => e.JobDescription).MaximumLength(300).WithMessage(BusinessMessages.MaxLengthError300);
            RuleFor(e => e.StartDate).NotEmpty().WithMessage(BusinessMessages.RequiredField);
            RuleFor(e => e.EndDate).NotEmpty().WithMessage(BusinessMessages.RequiredField);
            RuleFor(e => e.EndDate).GreaterThanOrEqualTo(e => e.StartDate).WithMessage("Bitiş tarihi, başlangıç tarihinden büyük veya eşit olmalıdır!");
            RuleFor(e => e.StartDate)
                   .Must(BeValidDate).WithMessage(BusinessMessages.DateFormatError);
            RuleFor(e => e.EndDate)
                .Must(BeValidDate).WithMessage(BusinessMessages.DateFormatError);
        }

        private bool BeValidDate(DateTime date)
        {
            return true;
        }
    }
}
