namespace Business.Dtos.Request.UpdateRequest
{
    public class UpdateAccountApplicationRequest
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int LessonId { get; set; }
    }
}
