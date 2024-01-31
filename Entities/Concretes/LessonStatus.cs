using Core.Entities;

namespace Entities.Concretes
{
    public class LessonStatus : Entity<int>
    {
        public int AccountId { get; set; }
        public int LessonId { get; set; }
        public string Name { get; set; }
        public Account? Account { get; set; }
        public Lesson? Lesson { get; set; }

    }
}
