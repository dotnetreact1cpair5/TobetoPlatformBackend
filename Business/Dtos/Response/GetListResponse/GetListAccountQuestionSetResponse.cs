using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response
{
    public class GetListAccountQuestionSetResponse
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int QuestionSetId { get; set; }
        public string QuestionSetName { get; set; }
        public string QuestionSetDesciption { get; set; }
        public string QuestionSetDuration { get; set; }
        public string QuestionSetTotalQuestion { get; set; }
        public string QuestionSetType { get; set; }
        public bool Status { get; set; }
    }
}
