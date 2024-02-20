using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response.CreatedResponse
{
    public class CreatedQuestionResponse
    {
        public int Id { get; set; }
        public int QuestionSetId { get; set; }
        public string Name { get; set; }
        public int Point { get; set; }
    }
}
