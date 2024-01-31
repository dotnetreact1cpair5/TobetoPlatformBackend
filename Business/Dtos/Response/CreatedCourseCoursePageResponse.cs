using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response
{
    public class CreatedCourseCoursePageResponse
    {
        public int Id { get; set; }
        public int CoursePageId { get; set; }
        public int CourseId { get; set; }
    }

}
