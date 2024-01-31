using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class CourseCoursePage : Entity<int>
    {
        public int CoursePageId { get; set; }
        public int CourseId { get; set; }

        public Course? Course { get; set; }
        public CoursePage? CoursePage { get; set; }
    }
}
