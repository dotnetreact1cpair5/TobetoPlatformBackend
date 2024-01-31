namespace Business.Dtos.Request
{
    public class UpdateCourseContentRequest
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int ContentTypeId { get; set; }
        public string Name { get; set; }
    }

}
