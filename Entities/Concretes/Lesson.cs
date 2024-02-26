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

        public virtual Course? Course { get; set; }
        public virtual Content? Content { get; set; }
        public virtual ContentType? ContentType { get; set; }
        public virtual Organization? Organization { get; set; }
        public virtual Category? Category { get; set; }
        public virtual SessionRecord? SessionRecord { get; set; }
        public virtual Instructor? Instructor { get; set; }
        public virtual PathFile? PathFile { get; set; }
        public virtual ICollection<LessonStatus>? Lessons { get; set; }  
        public virtual ICollection<LessonFavourite>? LessonsFavourites { get; set; }
    }
}
