namespace Business.Dtos.Response.CreatedResponse
{
    public class CreatedApplicationResponse
    {
        public int Id { get; set; }
        public int ApplicationStepId { get; set; }
        public int OrganizationId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string DocumentName { get; set; }
    }
}
