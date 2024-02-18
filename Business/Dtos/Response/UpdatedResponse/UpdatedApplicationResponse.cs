namespace Business.Dtos.Response.UpdatedResponse
{
    public class UpdatedApplicationResponse
    {
        public int Id { get; set; }
        public int ApplicationStepId { get; set; }
        public int OrganizationId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string DocumentName { get; set; }
    }
}
