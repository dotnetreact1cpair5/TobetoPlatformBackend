namespace Business.Dtos.Response.DeletedResponse
{
    public class DeletedAccountCertificateResponse
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string Name { get; set; }
        public string FileFormat { get; set; }
    }
}
