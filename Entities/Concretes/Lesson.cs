using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Lesson : Entity<int>
    {
        public int CategoryId { get; set; }
        public int ContentTypeId { get; set; }
        public int OrganizationId { get; set; }
        public int SessionRecordId { get; set; }
        public int PathFileId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public int VideoDuration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ContentType? ContentType { get; set; }
        public Organization? Organization { get; set; }
        public Category? CourseCategory { get; set; }
        public SessionRecord? SessionRecord { get; set; }
        public Instructor? Instructor { get; set; }
        public PathFile? PathFile { get; set; }
        public ICollection<CoursePageLesson>? CoursePageLessons { get; set; }



    }
}
