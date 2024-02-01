namespace Business.Dtos.Request.UpdateRequest
{
    public class UpdateAccountCertificateRequest
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string Name { get; set; }
    }
}
