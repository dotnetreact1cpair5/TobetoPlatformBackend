namespace Business.Dtos.Response
{
    public class GetListCourseResponse
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string OrganizationName { get; set; }
        public string ContentTypeName { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string EstimatedVideoDuration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
