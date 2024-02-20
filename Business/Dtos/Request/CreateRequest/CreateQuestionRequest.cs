using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request.CreateRequest
{
    public class CreateQuestionRequest
    {
        public int QuestionSetId { get; set; }
        public string Name { get; set; }
        public int Point { get; set; }
    }
}
