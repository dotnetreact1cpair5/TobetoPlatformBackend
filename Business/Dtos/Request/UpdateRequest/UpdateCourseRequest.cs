namespace Business.Dtos.Request.UpdateRequest
{
    public class UpdateCourseRequest
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int OrganizationId { get; set; }
        public int ContentTypeId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string EstimatedVideoDuration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }


}
