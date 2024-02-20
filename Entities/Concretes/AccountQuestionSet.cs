using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class AccountQuestionSet : Entity<int>
    {
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public int QuestionSetId { get; set; }
        public QuestionSet QuestionSet { get; set; }
        public bool Status { get; set; } //durumun 1 0 olmasına göre farklı isimlendirmeler var.

    }
}
