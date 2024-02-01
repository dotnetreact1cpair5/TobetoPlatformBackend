using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class CoursePage : Entity<int>
    {
        public int PathFileId { get; set; }
        public string Name { get; set; }
       // public PathFile? PathFile { get; set; }
        public ICollection<CoursePageLesson>? CoursePageLessons { get; set; }
        public ICollection<CourseCoursePage>? CourseCoursePages { get; set; }
        public ICollection<ContentCoursePage>? ContentCoursePages { get; set; }


    }
}
