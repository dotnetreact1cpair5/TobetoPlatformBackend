using Core.Entities;
using Core.Entities.Concrete;

namespace Entities.Concretes
{
    public class LessonStatus : Entity<int>
    {
        public int? UserId { get; set; }
        public int? LessonId { get; set; }
        public string Name { get; set; }
        public User? User { get; set; }
        public Lesson? Lesson { get; set; }

    }
}
