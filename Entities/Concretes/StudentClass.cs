using Core.Entities;
using Microsoft.EntityFrameworkCore.Storage;

namespace Entities.Concretes
{
    public class StudentClass : Entity<int>
    {
        public string Name { get; set; }
        public ICollection<ClassCourse>? ClassCourses { get; set; }
    }

}
