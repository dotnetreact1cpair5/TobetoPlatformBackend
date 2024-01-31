using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class CourseTimeSpent : Entity<int>
    {
        public int AccountId { get; set; }
        public int CourseId { get; set; }
        public string TimeSpent { get; set; }
        public Account? Account { get; set; }
        public Course? Course { get; set; }

    }
}
