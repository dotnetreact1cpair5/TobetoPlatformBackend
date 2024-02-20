using Core.Entities;
using Core.Entities.Concrete;

namespace Entities.Concretes
{
    public class AccountCourse : Entity<int>
    {
        public int? UserId { get; set; }
        public int LessonId { get; set; }
        public User? User { get; set; }  
        public Lesson? Lesson { get; set; }
      

    }

}
