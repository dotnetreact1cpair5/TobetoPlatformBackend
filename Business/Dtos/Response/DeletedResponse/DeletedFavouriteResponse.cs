namespace Business.Dtos.Response.DeletedResponse
{
    public class DeletedFavouriteResponse
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? CourseId { get; set; }
        public int? LessonId { get; set; }
    }


}
