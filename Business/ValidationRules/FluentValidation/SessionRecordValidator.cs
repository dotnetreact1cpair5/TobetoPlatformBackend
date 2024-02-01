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
    public class SessionRecordValidator : AbstractValidator<CreateSessionRecordRequest>
    {
        public SessionRecordValidator()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage(BusinessMessages.RequiredField);
            RuleFor(c => c.Name).MinimumLength(2).WithMessage(BusinessMessages.MinLengthError2);
            RuleFor(c => c.Name).MaximumLength(30).WithMessage(BusinessMessages.MaxLengthError30);
        }
    }

}
