namespace Business.Dtos.Response.UpdatedResponse
{
    public class UpdatedApplicationResponse
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public int Priority { get; set; }
        public bool Visibility { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}
