namespace Business.Dtos.Request.UpdateRequest
{
    public class UpdateAccountCourseRequest
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int LessonId { get; set; }
    }
}
