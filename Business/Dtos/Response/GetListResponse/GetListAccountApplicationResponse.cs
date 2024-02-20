namespace Business.Dtos.Response.GetListResponse
{
    public class GetListAccountApplicationResponse
    {
        public int UserId { get; set; }
        public string ApplicationName { get; set; }
        public string UserFirsLastName { get; set; }
        public string Organization {  get; set; }   
        public string Title {  get; set; }
        public string? Description { get; set; }
    }
}
