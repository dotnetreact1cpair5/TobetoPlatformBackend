﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request.CreateRequest
{
    public class CreateAccountQuestionSetRequest
    {
        public int AccountId { get; set; }
        public int QuestionSetId { get; set; }
        public bool Status { get; set; }
    }
}
