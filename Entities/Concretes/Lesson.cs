using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Lesson : Entity<int> //ok
    {
        public int CategoryId { get; set; }
        public int ContentTypeId { get; set; }
        public int OrganizationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
       
        public string Language { get; set; }
      
        public int VideoDuration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ContentType? ContentType { get; set; }
        public Organization? Organization { get; set; }
        public Category? CourseCategory { get; set; }

        //  public ICollection<Instructor> Instructors { get; set; } eğitmenler
        public ICollection<CoursePageLesson>? CoursePageLessons { get; set; }



    }
}
