namespace Business.Dtos.Request.CreateRequest
{
    public class CreateApplicationRequest
    {
        public int ApplicationStepId { get; set; }
        public int OrganizationId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string DocumentName { get; set; }
    }
}
