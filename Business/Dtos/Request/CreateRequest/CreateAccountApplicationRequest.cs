namespace Business.Dtos.Request.CreateRequest
{
    public class CreateAccountApplicationRequest
    {
        public int UserId { get; set; }
        public int ApplicationId { get; set; }
        public string Description { get; set; }
    }
}
