namespace Business.Dtos.Response.GetListResponse
{
    public class GetListFavouriteResponse
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string? CourseName { get; set; }
        public int? LessonId { get; set; }
    }


}
