using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class QuestionSet : Entity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public string TotalQuestion { get; set; }
        public string Type { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}
