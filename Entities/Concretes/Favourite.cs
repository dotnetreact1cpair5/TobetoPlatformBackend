using Core.Entities;
using Core.Entities.Concrete;

namespace Entities.Concretes
{
    public class Favourite : Entity<int>
    {
        public int? UserId { get; set; }
        public int? CourseId { get; set; }
        public int? LessonId { get; set; }
        public User? User { get; set; }
        public Course? Course { get; set; }
        public Lesson? Lesson { get; set; } 

    }


}
