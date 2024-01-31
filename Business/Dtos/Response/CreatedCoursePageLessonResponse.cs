using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response
{
    public class CreatedCoursePageLessonResponse
    {
        public int Id { get; set; }
        public int CoursePageId { get; set; }
        public int LessonId { get; set; }
    }
}
