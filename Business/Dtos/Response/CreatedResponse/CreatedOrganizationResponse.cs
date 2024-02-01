namespace Business.Dtos.Response.CreatedResponse
{
    public class CreatedOrganizationResponse
    {
        public int Id { get; set; }
        public int DistrictId { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
    }
}
