using Core.Entities;

namespace Entities.Concretes
{
    public class ClassCourse : Entity<int> //ok
    {
        public int CourseId { get; set; }
        public int AccountStudentClassId { get; set; }
        public Course? Course { get; set; }
        public AccountStudentClass? AccountStudentClass { get; set; }

    }

}
