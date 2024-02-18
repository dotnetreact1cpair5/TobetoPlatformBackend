namespace Business.Dtos.Response.GetListResponse
{
    public class GetListCourseResponse
    {
        public int Id { get; set; }
    
      //  public int UserId { get; set; }
        public string CategoryName { get; set; }
        public string OrganizationName { get; set; }
        public int ContentTypeId { get; set; }
        public string ContentTypeName { get; set; }
        public int PathFileUrl { get; set; }
        public string Name { get; set; }
        public string EstimatedVideoDuration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
