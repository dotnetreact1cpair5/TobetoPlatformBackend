using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class CoursePageLesson :Entity<int>
    {
        public int CoursePageId { get; set; }
        public int LessonId { get; set; }
        public CoursePage? CoursePage { get; set; }
        public Lesson? Lesson { get; set; }
    }
}
