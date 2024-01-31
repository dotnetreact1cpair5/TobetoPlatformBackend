using Core.Entities;

namespace Entities.Concretes
{
    public class LessonFavourite : Entity<int>
    {
        public int AccountId { get; set; }
        public int LessonId { get; set; }
        public Account? Account { get; set; }
        public Lesson? Lesson { get; set; }

    }




}
