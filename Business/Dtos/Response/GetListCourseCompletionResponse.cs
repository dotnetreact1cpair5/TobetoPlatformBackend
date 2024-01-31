namespace Business.Dtos.Response
{
    public class GetListCourseCompletionResponse
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string CourseName { get; set; }
        public double PercentageOfCompletion { get; set; }
        public double Point { get; set; }
    }


}
