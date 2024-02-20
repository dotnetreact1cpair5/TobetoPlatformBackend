using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response
{
    public class GetListAccountAnswerResponse
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int AnswerId { get; set; }
        public string AnswerName { get; set; } //örnek sil!
        public int QuestionSetId { get; set; }
        public bool IsCorrect { get; set; }
        public bool IsIncorrect { get; set; }
        public bool IsEmpty { get; set; }
    }
}
