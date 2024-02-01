using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Response.CreatedResponse
{
    public class CreatedClassLessonResponse
    {
        public int Id { get; set; }
        public int LessonId { get; set; }
        public int StudentClassId { get; set; }
    }
}
