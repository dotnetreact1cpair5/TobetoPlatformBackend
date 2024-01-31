using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request
{
    public class CreateClassLessonRequest
    {
        public int LessonId { get; set; }
        public int StudentClassId { get; set; }
    }

}
