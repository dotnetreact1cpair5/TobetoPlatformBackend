﻿using Business.Constants.Messages;
using Business.Dtos.Request.CreateRequest;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class SkillValidator:AbstractValidator<CreateSkillRequest>
    {
        public SkillValidator()
        {
            RuleFor(s=>s.Name).NotEmpty().WithMessage(BusinessMessages.RequiredField);
        }
    }
}
