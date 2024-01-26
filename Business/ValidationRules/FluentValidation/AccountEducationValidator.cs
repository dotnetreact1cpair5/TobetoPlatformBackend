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
    public class AccountEducationValidator : AbstractValidator<CreateAccountEducationRequest>
    {
        public AccountEducationValidator()
        {
            RuleFor(a => a.StartYear).NotEmpty().WithMessage(BusinessMessages.RequiredField)
                .Must(BeAValidYear).WithMessage(BusinessMessages.StartYearError);

            RuleFor(a => a.GraduationYear).NotEmpty().WithMessage(BusinessMessages.RequiredField)
                .Must(BeAValidYear).WithMessage(BusinessMessages.GraduationYearError)
                .GreaterThanOrEqualTo(a => a.StartYear).WithMessage(BusinessMessages.DateComparison);

            RuleFor(a => a.IsGraduated).NotEmpty().WithMessage(BusinessMessages.AccountApplicationCannotBeEmpty);
        }

        private bool BeAValidYear(DateTime year)
        {
            //Girilen tarihin geçerli zaman aralığında olup olmadığını kontrol etme.
            int currentYear = DateTime.Now.Year;
            return year.Year >= 1973 && year.Year <= currentYear;
        }
    }
}
