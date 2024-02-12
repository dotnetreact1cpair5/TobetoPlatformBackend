using Core.Entities;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Course : Entity<int>
    {
        public int AccountId { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public int OrganizationId { get; set; }
        public int ContentTypeId { get; set; }
        public int PathFileId { get; set; }
        public string Name { get; set; }
        public string EstimatedVideoDuration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Account? Account { get; set; }
        public User? User { get; set; }  
        public ContentType? ContentType { get; set; }
        public Category? Category { get; set; }
        public PathFile? PathFile { get; set; }
        public Organization? Organization { get; set; }
        public ICollection<CourseCoursePage>? CourseCoursePages { get; set; }
        public ICollection<ClassCourse>? ClassCourses { get; set; }


    }
}

