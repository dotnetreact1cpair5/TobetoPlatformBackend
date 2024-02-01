using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request
{
    public class CreateContentCoursePageRequest
    {
        public int CoursePageId { get; set; }
        public int ContentId { get; set; }
    }

}
