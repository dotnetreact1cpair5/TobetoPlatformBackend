namespace Business.Dtos.Request.UpdateRequest
{
    public class UpdateFavouriteRequest
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? CourseId { get; set; }
        public int? LessonId { get; set; }
    }


}
