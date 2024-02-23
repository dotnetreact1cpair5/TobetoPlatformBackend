using Core.Entities;
using Core.Entities.Concrete;

namespace Entities.Concretes
{
    public class LessonFavourite : Entity<int>
    {
        public int? UserId { get; set; }
        public int? LessonId { get; set; }
        public bool? IsFavourite {  get; set; }  
        public User? User { get; set; }
        public Lesson? Lesson { get; set; }

    }




}
