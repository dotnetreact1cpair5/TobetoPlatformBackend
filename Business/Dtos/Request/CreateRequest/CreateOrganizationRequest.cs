namespace Business.Dtos.Request.CreateRequest
{
    public class CreateOrganizationRequest
    {
        public int DistrictId { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
    }
}
