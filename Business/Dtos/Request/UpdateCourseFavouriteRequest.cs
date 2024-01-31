namespace Business.Dtos.Request
{
    public class UpdateCourseFavouriteRequest
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int CourseId { get; set; }
    }


}
