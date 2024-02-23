using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class AccountAnswer : Entity<int>
    {
        public int AccountId { get; set; }
        public Account Account { get; set; }

        public int AnswerId { get; set; }
        public Answer Answer { get; set; }

        public int QuestionId { get; set; }
        public Question Question { get; set; }

        public int QuestionSetId { get; set; }
        public QuestionSet QuestionSet { get; set; }

        public bool IsCorrect { get; set; }
        public bool IsIncorrect { get; set; }
        public bool IsEmpty { get; set; }
        
         
    }
}
