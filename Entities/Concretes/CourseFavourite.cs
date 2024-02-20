using Core.Entities;
using Core.Entities.Concrete;

namespace Entities.Concretes
{
    public class CourseFavourite : Entity<int>
    {
        public int? UserId { get; set; }
        public int? CourseId { get; set; }
        public User? User { get; set; }
        public Course? Course { get; set; }

    }




}
