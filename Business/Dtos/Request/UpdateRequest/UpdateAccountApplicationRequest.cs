namespace Business.Dtos.Request.UpdateRequest
{
    public class UpdateAccountApplicationRequest
    {
        public int Id { get; set; }
        public int AccountId { get; set; }

        public int ApplicationStepId { get; set; }
    }
}
