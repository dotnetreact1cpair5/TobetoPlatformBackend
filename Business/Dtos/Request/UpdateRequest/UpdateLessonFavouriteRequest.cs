namespace Business.Dtos.Request.UpdateRequest
{
    public class UpdateLessonFavouriteRequest
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int LessonId { get; set; }
    }


}
