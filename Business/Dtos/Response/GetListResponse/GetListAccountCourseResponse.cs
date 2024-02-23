using Entities.Concretes;

namespace Business.Dtos.Response.GetListResponse
{
    public class GetListAccountCourseResponse
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CourseName { get; set; }
        public string ContentName { get; set; }
        public string LessonName { get; set; }
        public string SessionRecord { get; set; }
        public string Instructor { get; set; }
        public string CategoryLesson { get; set; }
        public string CategoryCourse { get; set; }
        public string OrganizationName { get; set; }
        public string ContentTypeCourse { get; set; }
        public string ContentTypeLesson { get; set; }
        public string PathFileCourse { get; set; }
        public string PathFileLesson { get; set; }
        public string EstimatedVideoDuration { get; set; }
        public string LessonVideoDuration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreatedDate { get; set; }
        
    }
}
