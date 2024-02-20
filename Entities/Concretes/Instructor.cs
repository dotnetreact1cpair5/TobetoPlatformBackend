using Core.Entities;

namespace Entities.Concretes
{
    public class Instructor : Entity<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Lesson>? Lessons { get; set; }

    }

}
