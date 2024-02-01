namespace Business.Dtos.Response.UpdatedResponse
{
    public class UpdatedOrganizationResponse
    {
        public int Id { get; set; }
        public int AddressId { get; set; }
        public int Priority { get; set; }
        public bool Visibility { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
    }
}
