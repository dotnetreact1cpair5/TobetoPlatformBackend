namespace Business.Dtos.Response.GetListResponse
{
    public class GetListLessonResponse
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string ContentName { get; set; }
        public string ContentTypeName { get; set; }
        public string OrganizationName { get; set; }
        public string CategoryName { get; set; }
        public string SessionRecordName { get; set; }
        public string InstructorName { get; set; }
        public string PathFileUrl { get; set; }
        public string Name { get; set; }
        public string Language { get; set; }
        public string VideoDuration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
