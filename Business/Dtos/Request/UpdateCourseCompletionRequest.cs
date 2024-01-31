namespace Business.Dtos.Request
{
    public class UpdateCourseCompletionRequest
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int CourseId { get; set; }
        public double PercentageOfCompletion { get; set; }
        public double Point { get; set; }
    }


}
