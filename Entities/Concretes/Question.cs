using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Question : Entity<int>
    {
        public int QuestionSetId { get; set; }
        public QuestionSet QuestionSet { get; set; }
        public string Name { get; set; }
        public int Point { get; set; }
        public ICollection<Answer> Answers { get; set; }

        //Question Image özelliği gelmeli!!!
    }
}
