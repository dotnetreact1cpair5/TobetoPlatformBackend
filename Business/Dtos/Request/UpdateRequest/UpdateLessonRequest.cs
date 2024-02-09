namespace Business.Dtos.Request.UpdateRequest
{
    public class UpdateLessonRequest
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int ContentId { get; set; }
        public int ContentTypeId { get; set; }
        public int OrganizationId { get; set; }
        public int CategoryId { get; set; }
        public int SessionRecordId { get; set; }
        public int PathFileId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public int VideoDuration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
