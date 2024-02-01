using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request.CreateRequest
{
    public class CreateClassLessonRequest
    {
        public int LessonId { get; set; }
        public int StudentClassId { get; set; }
    }

}
