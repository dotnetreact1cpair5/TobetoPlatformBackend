using Core.Entities;

namespace Entities.Concretes
{
    public class Content : Entity<int>
    {
        public string Name { get; set; }

        public ICollection<ContentCoursePage>? ContentCoursePages { get; set; }
    }
}
