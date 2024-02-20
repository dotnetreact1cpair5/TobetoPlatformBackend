using Core.Entities;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class CourseCompletion : Entity<int>
    {
        public int? UserId { get; set; }
        public int? CourseId { get; set; }
        public double PercentageOfCompletion { get; set; }
        public double Point { get; set; }
        public  User? User { get; set; }
        public  Course? Course { get; set; }

    }
}
