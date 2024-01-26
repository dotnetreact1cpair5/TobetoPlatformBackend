namespace Business.Dtos.Request
{
    public class UpdateCourseRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Image { get; set; }
    }    
}
