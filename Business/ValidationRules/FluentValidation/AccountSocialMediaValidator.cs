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
    public class AccountSocialMediaValidator : AbstractValidator<CreateAccountSocialMediaRequest>
    {
        public AccountSocialMediaValidator()
        {
            RuleFor(a => a.Link)
                .NotEmpty().WithMessage(BusinessMessages.RequiredField)
                .Must(BeAValidUrl).WithMessage(BusinessMessages.InvalidUrlError);
        }

        private bool BeAValidUrl(string url)
        {
            if (Uri.TryCreate(url, UriKind.Absolute, out Uri validatedUri))
            {
                return true;
            }

            return false;
        }
    }
}
