using Core.Entities;

namespace Entities.Concretes
{
    public class CourseFavourite : Entity<int>
    {
        public int AccountId { get; set; }
        public int CourseId { get; set; }
        public Account? Account { get; set; }
        public Course? Course { get; set; }

    }




}
