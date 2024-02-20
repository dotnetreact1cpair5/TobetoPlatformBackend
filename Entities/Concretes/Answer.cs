using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Answer : Entity<int>
    {
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public string Name { get; set; }
        public bool IsCorrect { get; set; }
    }
}
