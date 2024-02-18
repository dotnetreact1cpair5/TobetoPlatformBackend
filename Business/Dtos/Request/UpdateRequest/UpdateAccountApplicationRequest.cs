namespace Business.Dtos.Request.UpdateRequest
{
    public class UpdateAccountApplicationRequest
    {
        public int UserId { get; set; }
        public int ApplicationId { get; set; }
        public string? Description { get; set; }
    }
}
