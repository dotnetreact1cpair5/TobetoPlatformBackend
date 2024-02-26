namespace Business.Dtos.Response.GetListResponse
{
    public class GetListAccountEducationResponse
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string EducationStatusName { get; set; }
        public string UniversityName { get; set; }
        public string EducationProgramName { get; set; }
        public DateTime StartYear { get; set; }
        public DateTime GraduationYear { get; set; }
        public bool IsGraduated { get; set; }
    }
}
