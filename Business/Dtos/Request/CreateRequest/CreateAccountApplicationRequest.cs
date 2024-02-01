namespace Business.Dtos.Request.CreateRequest
{
    public class CreateAccountApplicationRequest
    {
        public int AccountId { get; set; }

        public int ApplicationStepId { get; set; }
        public string DocumentName { get; set; }
    }
}
