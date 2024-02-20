using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Request.CreateRequest
{
    public class CreateLessonRequest
    {
        public int CourseId { get; set; }
        public int ContentId { get; set; }
        public int ContentTypeId { get; set; }
        public int OrganizationId { get; set; }
        public int CategoryId { get; set; }
        public int? SessionRecordId { get; set; }
        public int? InstructorId { get; set; }
        public int PathFileId { get; set; }
        public string Name { get; set; }
        public string Language { get; set; }
        public string VideoDuration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
