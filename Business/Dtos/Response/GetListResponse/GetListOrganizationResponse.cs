namespace Business.Dtos.Response.GetListResponse
{
    public class GetListOrganizationResponse
    {
        public int Id { get; set; }
        public string DistrictName { get; set; }
        public string CityName { get; set; }
        public string CountryName { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
    }
}
