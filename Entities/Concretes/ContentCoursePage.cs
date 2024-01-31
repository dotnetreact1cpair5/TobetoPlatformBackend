using Core.Entities;

namespace Entities.Concretes
{
    public class ContentCoursePage : Entity<int>
    {
        public int CoursePageId { get; set; }
        public int ContentId { get; set; }

        public Content? Content { get; set; }
        public CoursePage? CoursePage { get; set; }
    }
}
