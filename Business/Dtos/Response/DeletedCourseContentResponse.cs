namespace Business.Dtos.Response
{
    public class DeletedCourseContentResponse
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int ContentTypeId { get; set; }
        public string Name { get; set; }
    }
}
