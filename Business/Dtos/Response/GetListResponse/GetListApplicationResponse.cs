namespace Business.Dtos.Response.GetListResponse
{
    public class GetListApplicationResponse
    {
        public int Id { get; set; }
        public string ApplicationStepName { get; set; }
        public string OrganizationName { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string DocumentName { get; set; }
    }
}
