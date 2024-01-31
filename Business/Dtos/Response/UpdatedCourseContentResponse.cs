namespace Business.Dtos.Response
{
    public class UpdatedCourseContentResponse
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int ContentTypeId { get; set; }
        public string Name { get; set; }
    }
}
